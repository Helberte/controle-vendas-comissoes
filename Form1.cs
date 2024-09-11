using controle_vendas_comissoes.Biblioteca.Utils;
using controle_vendas_comissoes.Configuracoes.Db.Entidades;
using controle_vendas_comissoes.Configuracoes.Db.Helpers;
using FontAwesome.Sharp;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing.Drawing2D;

namespace controle_vendas_comissoes
{
    public partial class CvcMain : MaterialForm
    {
        private static List<Menu>? menus = null;

        #region Componentes Visuais

        private static Panel? panelEsquerdaMenu = null;
        private static Panel? panelMenusFilhos  = null;

        #endregion

        #region Construtores

        public CvcMain()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        #endregion

        #region Eventos

        private void CvcMain_Load(object sender, EventArgs e)
        {
            ArredondaCantos(CardCabecalho);
            ArredondaCantos(CardMenuLateral);

            ListarMenus();
        }

        private void MenusPais_Click(object? sender, EventArgs e)
        {
            List<Menu> menusFilho = [];
            IconButton botao;
      
            if (sender is not null)
            {
                ResetaCorBotoesMenuEsquerdo();

                botao = (IconButton)sender;
                botao.ForeColor = Color.FromArgb(0, 88, 255);
                botao.IconColor = Color.FromArgb(0, 88, 255);
                botao.BackColor = Color.FromArgb(222, 232, 248);

                menusFilho = [.. menus?.FindAll(x => x.Pai == (botao.Tag as Menu)?.Codigo)];

                if (menusFilho.Count > 0)
                {
                    Panel panelSubMenus = CvcMain.GetPanelMenusFilhos();

                    panelSubMenus.Width     = CardMenuLateral.Width;
                    panelSubMenus.Height    = 100;
                    panelSubMenus.BackColor = Color.Blue;

                    CardMenuLateral.Controls.Add(panelSubMenus);

                    ReorganizaBotoes(botao);
                }

                PosicionaMarcacaoBotaoClicado(botao);
            }
        }

        #endregion

        #region Metodos

        private void PosicionaMarcacaoBotaoClicado(IconButton iconButton)
        {
            Panel panel;

            panel = CvcMain.GetPanelEsquerdaButtonMenu(iconButton.Height, iconButton.Width);

            panel.Location = new Point(0, iconButton.Location.Y);
            CardMenuLateral.Controls.Add(panel);
        }

        private static void ArredondaCantos(Control control)
        {
            using GraphicsPath forma = new();

            forma.AddRectangle(new Rectangle(1, 1, control.Width, control.Height));
            forma.AddRectangle(new Rectangle(1, 1, 10, 10));
            forma.AddPie(1, 1, 20, 20, 180, 90);
            forma.AddRectangle(new Rectangle(control.Width - 12, 1, 12, 13));
            forma.AddPie(control.Width - 24, 1, 24, 26, 270, 90);
            forma.AddRectangle(new Rectangle(1, control.Height - 10, 10, 10));
            forma.AddPie(1, control.Height - 20, 20, 20, 90, 90);
            forma.AddRectangle(new Rectangle(control.Width - 12, control.Height - 13, 13, 13));
            forma.AddPie(control.Width - 24, control.Height - 26, 24, 26, 0, 90);
            forma.SetMarkers();

            control.Region = new Region(forma);

            //https://pt.stackoverflow.com/questions/528084/%C3%89-poss%C3%ADvel-fazer-bordas-arredondadas-no-combobox-do-windows-forms-c
        }

        private static Panel GetPanelEsquerdaButtonMenu(int altura, int largura)
        {
            CvcMain.panelEsquerdaMenu ??= new Panel()
            {
                Width     = largura,
                Height    = altura,
                BackColor = Color.FromArgb(0, 88, 255)
            };

            return panelEsquerdaMenu;
        }

        private static IconChar GetIconChar(string nome)
        {
            IconChar icon = IconChar.ArrowRight;

            if (nome.Equals("MapLocationDot"))
                icon = IconChar.MapLocationDot;
            else if (nome.Equals("PeopleGroup"))
                icon = IconChar.PeopleGroup;
            else if (nome.Equals("BottleDroplet"))
                icon = IconChar.BottleDroplet;
            else if (nome.Equals("HandHoldingUsd"))
                icon = IconChar.HandHoldingUsd;
            else if (nome.Equals("MoneyBillTrendUp"))
                icon = IconChar.MoneyBillTrendUp;

            return icon;
        }

        private void SetBotaoPai(Menu menu, int totalBotoes)
        {
            IconButton botao = new();
            int heightBotao = 0;

            botao.BackColor = System.Drawing.Color.Transparent;
            botao.Height = 55;
            botao.Width = 190;
            botao.Text = menu.Nome;
            CardMenuLateral.Controls.Add(botao);

            if (totalBotoes > 0)
                heightBotao = botao.Height * totalBotoes;

            botao.Tag       = menu;
            botao.Location  = new Point(5, heightBotao);
            botao.FlatStyle = FlatStyle.Flat;
            botao.FlatAppearance.BorderSize = 0;
            botao.IconChar  = GetIconChar(menu.Icone ?? "");
            botao.IconColor = Color.FromArgb(0, 120, 111);
            botao.ForeColor = Color.FromArgb(0, 120, 111);
            botao.TextImageRelation = TextImageRelation.ImageBeforeText;
            botao.IconSize      = 28;
            botao.TextAlign     = ContentAlignment.MiddleLeft;
            botao.ImageAlign    = ContentAlignment.MiddleLeft;
            botao.Padding       = new Padding(10, 0, 0, 0);

            botao.Click += MenusPais_Click;

            botao.BackgroundImage = null;
        }

        private void ResetaCorBotoesMenuEsquerdo()
        {
            if (CardMenuLateral is not null)
            {
                foreach (Control item in CardMenuLateral.Controls)
                {
                    if (item is IconButton button)
                    {
                        button.ForeColor = Color.FromArgb(0, 120, 111);
                        button.IconColor = Color.FromArgb(0, 120, 111);
                        button.BackColor = Color.Transparent;
                    }
                }                
            }
        }

        private static Panel GetPanelMenusFilhos()
        {
            CvcMain.panelMenusFilhos ??= new Panel();

            return CvcMain.panelMenusFilhos;
        }

        private static Label GetLabelSubMenuLateral(Menu menu, int largura)
        {
            Label label = new()
            {
                Tag         = menu,
                Text        = menu.Nome,
                ForeColor   = Color.FromArgb(0, 120, 111),
                BackColor   = Color.Transparent,
                AutoSize    = false,
                Height      = 30,
                Width       = largura,
                TextAlign   = ContentAlignment.MiddleLeft,
                Padding     = new Padding(50, 0, 0, 0)
            };

            return label;
        }

        private void ReorganizaBotoes(IconButton button)
        {
            int altura = 0;

            foreach (Control item in CardMenuLateral.Controls)
            {
                if (item is IconButton botaoMenu)
                {
                    item.Location = new Point(5, altura);
                    altura = item.Location.Y + item.Height;
                }
            }

            if (CvcMain.panelMenusFilhos is not null)
            {
                for (int i = 0; i < CardMenuLateral.Controls.Count; i++)
                {
                    if (CardMenuLateral.Controls[i] is IconButton botaoMenu)
                    {
                        Menu? btAtual = botaoMenu.Tag as Menu;
                        Menu? btButton = button.Tag as Menu;

                        if (btAtual != null && btButton != null)
                        {
                            if (btAtual.Codigo.Equals(btButton.Codigo))
                            {
                                CvcMain.panelMenusFilhos.Location = new Point(5, botaoMenu.Location.Y + botaoMenu.Height);

                                int alturaTotal = CvcMain.panelMenusFilhos.Location.Y + CvcMain.panelMenusFilhos.Height;

                                for (int j = i + 1; j < CardMenuLateral.Controls.Count; j++)
                                {
                                    if (CardMenuLateral.Controls[j] is IconButton botaoRestante)
                                    {
                                        botaoRestante.Location = new Point(5, alturaTotal);
                                        alturaTotal = botaoRestante.Location.Y + botaoRestante.Height;
                                    }
                                }

                                break;
                            }
                        }

                    }
                }
            }
        }

        #endregion

        #region Requisições

        private void ListarMenus()
        {
            Utils.ExibeCarregando(this);

            HelperMenu.ObtemMenus().Then(listaMenus =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    CvcMain.menus = listaMenus;

                    List<Menu> menusPai = [.. menus.FindAll(x => string.IsNullOrEmpty(x.Pai)).OrderBy(x => x.Ordem)];

                    for (int i = 0; i < menusPai.Count; i++)
                        SetBotaoPai(menusPai[i], i);

                    Utils.EscondeCarregando(() =>
                    {
                        this.Enabled = true;
                    });
                });
            }).Catch(erro =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    MessageBox.Show(erro.Message);
                });
            });
        }

        #endregion
    }
}
