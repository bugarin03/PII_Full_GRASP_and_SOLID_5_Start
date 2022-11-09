using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IDistributor distributor)
        {
            File.WriteAllText("Recipe.txt", distributor.GetTextToPrint());
        }
    }
}