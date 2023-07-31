using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        Console.WriteLine(@"
        
        _______ ______   __  __          _____  _____ 
     /\|__   __|  ____| |  \/  |   /\   |_   _|/ ____|
    /  \  | |  | |__    | \  / |  /  \    | | | (___  
   / /\ \ | |  |  __|   | |\/| | / /\ \   | |  \___ \ 
  / ____ \| |  | |____  | |  | |/ ____ \ _| |_ ____) |
 /_/    \_\_|  |______| |_|  |_/_/    \_\_____|_____/ 
                                                                                                           
");
    }
}
