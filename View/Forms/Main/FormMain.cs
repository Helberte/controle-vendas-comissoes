using System.Data;
using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.Model.Db.Helpers.Menu;
using FontAwesome.Sharp;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace controle_vendas_comissoes.View.Forms.Main
{
    public partial class FormMain : Form
    {
        #region Variáveis

        private static List<Menu>? menus = null;
        private readonly List<Control> shadowControls = [];
        Bitmap? shadowBmp = null;

        #endregion

        #region Componentes Visuais

        private static Panel? panelEsquerdaMenu = null;
        private static Panel? panelMenusFilhos = null;

        #endregion

        #region Construtores e Overrides

        public FormMain()
        {
            InitializeComponent();            
        }
        
        #endregion

        #region Eventos

        private void FormMain_Load(object sender, EventArgs e)
        {
            ArredondaCantos(CardMenuLateral);

            //ListarMenus();

            ConfiguracaoLayout();
            ConfiguraSombra();
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
                    FormMain.GetPanelMenusFilhos().Visible = false;
                    FormMain.GetPanelMenusFilhos().Controls.Clear();
                    FormMain.GetPanelMenusFilhos().Width = CardMenuLateral.Width;
                    FormMain.GetPanelMenusFilhos().BackColor = Color.Transparent;

                    SetBotoesFilho(menusFilho);

                    CardMenuLateral.Controls.Add(FormMain.GetPanelMenusFilhos());

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

        private void timerDataHora_Tick(object sender, EventArgs e)
        {
            lblCidadeData.Text = "JARU - RO  " + string.Format("{0:dd-MM-yyyy}", DateTime.Now) + " - " + string.Format("{0:HH:mm}", DateTime.Now);
        }

        private void FormMain_Paint(object? sender, PaintEventArgs e)
        {
            if (shadowBmp == null || shadowBmp.Size != this.Size)
            {
                shadowBmp?.Dispose();
                shadowBmp = new Bitmap(this.Width, this.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            }
            foreach (Control control in shadowControls)
            {
                using (GraphicsPath gp = new())
                {
                    gp.AddRectangle(new Rectangle(control.Location.X, control.Location.Y, control.Size.Width, control.Size.Height));
                    DrawShadowSmooth(gp, 50, 28, shadowBmp);
                }
                e.Graphics.DrawImage(shadowBmp, new Point(0, 0));
            }
        }

        #endregion

        #region Metodos

        private void PosicionaMarcacaoBotaoClicado(IconButton iconButton)
        {
            Panel panel;

            panel = FormMain.GetPanelEsquerdaButtonMenu(iconButton.Height, iconButton.Width);

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
            FormMain.panelEsquerdaMenu ??= new Panel()
            {
                Width = largura,
                Height = altura,
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

            botao.Tag = menu;
            botao.Location = new Point(5, heightBotao);
            botao.FlatStyle = FlatStyle.Flat;
            botao.FlatAppearance.BorderSize = 0;
            botao.IconChar = GetIconChar(menu.Icone ?? "");
            botao.IconColor = Color.FromArgb(0, 120, 111);
            botao.ForeColor = Color.FromArgb(0, 120, 111);
            botao.TextImageRelation = TextImageRelation.ImageBeforeText;
            botao.IconSize = 28;
            botao.TextAlign = ContentAlignment.MiddleLeft;
            botao.ImageAlign = ContentAlignment.MiddleLeft;
            botao.Padding = new Padding(10, 0, 0, 0);

            botao.Click += MenusPais_Click;

            botao.BackgroundImage = null;
        }

        private static void SetBotoesFilho(List<Menu> menus)
        {
            int heightBotao = 0;
            int heightPanel = 0;

            foreach (Menu item in menus)
            {
                Label botao = FormMain.GetLabelSubMenuLateral(item, FormMain.GetPanelMenusFilhos().Width);

                botao.Location = new Point(0, heightBotao);
                heightBotao = botao.Location.Y + botao.PreferredHeight;
                heightPanel += botao.PreferredHeight;

                FormMain.GetPanelMenusFilhos().Controls.Add(botao);
            }

            FormMain.GetPanelMenusFilhos().Height = heightPanel;
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
            FormMain.panelMenusFilhos ??= new Panel();

            return FormMain.panelMenusFilhos;
        }

        private static Label GetLabelSubMenuLateral(Menu menu, int largura)
        {
            Label label = new()
            {
                AutoSize = true,
                MaximumSize = new Size(largura, 60),
                Width = largura,
                BorderStyle = BorderStyle.None,
                Tag = menu,
                Text = menu.Nome,
                ForeColor = Color.FromArgb(0, 120, 111),
                BackColor = Color.Transparent,
                Font = new Font("montserrat", 10),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(45, 5, 0, 5)
            };

            label.MouseMove += LabelSubsMenus_MouseMove;
            label.MouseLeave += LabelSubsMenus_MouseLeave;
            label.Click += LabelSubsMenus_Click;

            return label;
        }

        private void ReorganizaBotoes(IconButton? button = null)
        {
            int altura = 0;

            if (FormMain.panelMenusFilhos is not null && button is not null)
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

                                FormMain.panelMenusFilhos.Location = new Point(5, botaoMenu.Location.Y + botaoMenu.Height);

                                int alturaTotal = FormMain.panelMenusFilhos.Location.Y + FormMain.panelMenusFilhos.Height;

                                FormMain.GetPanelMenusFilhos().Visible = true;

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

        private void ConfiguracaoLayout()
        {
            lblCidadeData.Location = new Point(CardCabecalho.Width - lblCidadeData.Width - 20, (CardCabecalho.Height / 2) - (lblCidadeData.Height / 2));
        }

        private static void DrawShadowSmooth(GraphicsPath gp, int intensity, int radius, Bitmap dest)
        {
            using (Graphics g = Graphics.FromImage(dest))
            {
                g.Clear(Color.Transparent);
                g.CompositingMode = CompositingMode.SourceCopy;
                double alpha = 0;
                double astep = 0;
                double astepstep = (double)intensity / radius / (radius / 2D);
                for (int thickness = radius; thickness > 0; thickness--)
                {
                    using (Pen p = new Pen(Color.FromArgb((int)alpha, 0, 0, 0), thickness))
                    {
                        p.LineJoin = LineJoin.Round;
                        g.DrawPath(p, gp);
                    }
                    alpha += astep;
                    astep += astepstep;
                }
            }
        }

        private void ConfiguraSombra()
        {
            shadowControls.Add(CardCabecalho);
            this.Paint += FormMain_Paint;

            this.Refresh();
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
                    FormMain.menus = listaMenus;

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
