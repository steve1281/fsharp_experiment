open System
open System.Windows
open System.Windows.Controls
open System.Windows.Markup

[<STAThread>]
[<EntryPoint>]
let main argv = 
    let mainWindow = Application.LoadComponent(
                        new System.Uri("fsharp_experiment;component/MainWindow.xaml", UriKind.Relative)) :?> Window
    let application = new Application()
    application.Run(mainWindow)
