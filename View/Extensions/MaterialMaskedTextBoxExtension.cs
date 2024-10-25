using MaterialSkin.Controls;

namespace controle_vendas_comissoes.View.Extensions
{
    public static class MaterialMaskedTextBoxExtension
    {
        public static string GetText(this MaterialMaskedTextBox mask)
        {
            char[] invalidos   = [',', '.', ' ', '-', '/', '_'];
            string maskText    = mask.Text;
            string varAuxiliar = string.Empty;

            foreach (char inv in invalidos)
            {
                varAuxiliar = maskText.Replace(inv.ToString(), "");
                maskText    = varAuxiliar;
            }           
            
            return maskText;
        }
    }
}
