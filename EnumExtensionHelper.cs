using System.ComponentModel;
using System.Reflection;

namespace ExemploEnumsDescricao_ConsoleApp
{
    internal static class EnumExtensionHelper
    {

        public static string GetDescription(Enum element)
        {
            // Recupero a chave do elemento
            FieldInfo elementInfo = element.GetType().GetField(element.ToString())!;

            // Recuperamos o seu atributo Description
            var attributes = (DescriptionAttribute[])elementInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            // Se existe algum atributo
            if (attributes.Length > 0)
            {
                // Verifico se existe alguma descrição, pode haver enumeradores onde não haja descrição
                if (attributes[0].Description != null)
                    return attributes[0].Description;
                else
                    return "Sem descrição";     // Se não há descrição, retorno uma mensagem genérica
            }
            else
                return element.ToString();
        }
    }
}
