using controle_vendas_comissoes.Biblioteca.Utils;
using controle_vendas_comissoes.Configuracoes.Db.Entidades;
using controle_vendas_comissoes.Configuracoes.Db.Helpers;
using FontAwesome.Sharp;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace controle_vendas_comissoes
{
    public partial class CvcMain : Form
    {
        #region Variáveis

        private static List<Menu>? menus = null;
        
        #endregion

        #region Componentes Visuais

        private static Panel? panelEsquerdaMenu = null;
        private static Panel? panelMenusFilhos  = null;

        #endregion

        #region Construtores e Overrides

        public CvcMain()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void CvcMain_Load(object sender, EventArgs e)
        {
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
                    CvcMain.GetPanelMenusFilhos().Visible = false;
                    CvcMain.GetPanelMenusFilhos().Controls.Clear();
                    CvcMain.GetPanelMenusFilhos().Width     = CardMenuLateral.Width;
                    CvcMain.GetPanelMenusFilhos().BackColor = Color.Transparent;

                    SetBotoesFilho(menusFilho);

                    CardMenuLateral.Controls.Add(CvcMain.GetPanelMenusFilhos());

                    ReorganizaBotoes(botao);
                }
                else
                    ReorganizaBotoes();

                PosicionaMarcacaoBotaoClicado(botao);
            }
        }

        private static void LabelSubsMenus_MouseMove(object? sender, MouseEventArgs e)
        {           
            if (sender is Label rotulo)            
                rotulo.Font = new Font(rotulo.Font, FontStyle.Underline);                       
        }

        private static void LabelSubsMenus_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is Label rotulo)
                rotulo.Font = new Font(rotulo.Font, FontStyle.Regular);
        }

        private static void LabelSubsMenus_Click(object? sender, EventArgs e)
        {
            if (sender is Label subMenu)
            {
                if (subMenu.Tag is Menu menu)
                {
                    if (!string.IsNullOrEmpty(menu.Path))
                    {
                        MethodInfo? method = typeof(RedirectMenu).GetMethod(menu.Path);

                        method?.Invoke(null, null);
                    }
                }
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
            botao.Height    = 55;
            botao.Width     = 190;
            botao.Text      = menu.Nome;
            CardMenuLateral.Controls.Add(botao);

            if (totalBotoes > 0)
                heightBotao = botao.Height * totalBotoes;

            botao.Tag           = menu;
            botao.Location      = new Point(5, heightBotao);
            botao.FlatStyle     = FlatStyle.Flat;
            botao.FlatAppearance.BorderSize = 0;
            botao.IconChar      = GetIconChar(menu.Icone ?? "");
            botao.IconColor     = Color.FromArgb(0, 120, 111);
            botao.ForeColor     = Color.FromArgb(0, 120, 111);
            botao.TextImageRelation = TextImageRelation.ImageBeforeText;
            botao.IconSize      = 28;
            botao.TextAlign     = ContentAlignment.MiddleLeft;
            botao.ImageAlign    = ContentAlignment.MiddleLeft;
            botao.Padding       = new Padding(10, 0, 0, 0);

            botao.Click += MenusPais_Click;

            botao.BackgroundImage = null;
        }

        private static void SetBotoesFilho(List<Menu> menus)
        {
            int heightBotao = 0;
            int heightPanel = 0;
                       
            foreach (Menu item in menus)
            {
                Label botao    = CvcMain.GetLabelSubMenuLateral(item, CvcMain.GetPanelMenusFilhos().Width);

                botao.Location = new Point(0, heightBotao);
                heightBotao    = botao.Location.Y + botao.PreferredHeight;
                heightPanel   += botao.PreferredHeight;

                CvcMain.GetPanelMenusFilhos().Controls.Add(botao);                  
            }

            CvcMain.GetPanelMenusFilhos().Height = heightPanel;
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
                AutoSize    = true,
                MaximumSize = new Size(largura, 60),
                Width       = largura,
                BorderStyle = BorderStyle.None,
                Tag         = menu,
                Text        = menu.Nome,
                ForeColor   = Color.FromArgb(0, 120, 111),
                BackColor   = Color.Transparent,
                Font        = new Font("montserrat", 10),
                TextAlign   = ContentAlignment.MiddleLeft,
                Padding     = new Padding(45, 5, 0, 5)
            };

            label.MouseMove  += LabelSubsMenus_MouseMove;
            label.MouseLeave += LabelSubsMenus_MouseLeave;
            label.Click      += LabelSubsMenus_Click;

            return label;
        }

        private void ReorganizaBotoes(IconButton? button = null)
        {
            int altura = 0;

            if (CvcMain.panelMenusFilhos is not null && button is not null)
            {
                for (int i = 0; i < CardMenuLateral.Controls.Count; i++)
                {
                    if (CardMenuLateral.Controls[i] is IconButton botaoMenu)
                    {
                        if (botaoMenu.Tag is Menu btAtual && button.Tag is Menu btButton)
                        {
                            if (btAtual.Codigo.Equals(btButton.Codigo))
                            {
                                botaoMenu.Location = new Point(5, altura);

                                CvcMain.panelMenusFilhos.Location = new Point(5, botaoMenu.Location.Y + botaoMenu.Height);
                                
                                int alturaTotal = CvcMain.panelMenusFilhos.Location.Y + CvcMain.panelMenusFilhos.Height;

                                CvcMain.GetPanelMenusFilhos().Visible = true;

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
                            else
                            {
                                botaoMenu.Location = new Point(5, altura);
                                altura = botaoMenu.Location.Y + botaoMenu.Height;
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
