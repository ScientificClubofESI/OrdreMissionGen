using System;
using System.Windows;



namespace OrdreMissionGen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static string path = System.IO.Directory.GetCurrentDirectory();
        public static string env = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\OrdresMissions\\";


        private void BtnRemplir_Click(object sender, RoutedEventArgs e)
        {
            
            var application    = new Microsoft.Office.Interop.Word.Application();
            application.Visible = false;

            var FormulaireBG = new Microsoft.Office.Interop.Word.Document();
            var FormulaireVide = new Microsoft.Office.Interop.Word.Document();

            FormulaireBG = application.Documents.Add(Template: @"" + path + "\\Templates\\ModeleMission_BG.docx");

            foreach (Microsoft.Office.Interop.Word.Field field in FormulaireBG.Fields)
            {

                if (field.Code.Text.Contains("NumMission"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(MissionNumber.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);

                    }

                }

                else if (field.Code.Text.Contains("LastN"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(MissionNom.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }

                else if (field.Code.Text.Contains("FirstN"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(MissionPrenom.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }

                else if (field.Code.Text.Contains("MissionPoste"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(MissionPoste.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }

                else if (field.Code.Text.Contains("MissionAdr"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(MissionAdresse.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }

                else if (field.Code.Text.Contains("LieuMission"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(LieuMission.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }

                else if (field.Code.Text.Contains("MotifMission"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(MotifMission.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }

                else if (field.Code.Text.Contains("MoyTransport"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(MoyenTransport.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }

                else if (field.Code.Text.Contains("DateSortieMission"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(DateSortieEnMission.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }

                else if (field.Code.Text.Contains("DateEntreeMission"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(DateEntreeDeMission.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }

                else if (field.Code.Text.Contains("TypeIdentité"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(TypeIdentite.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }

                else if (field.Code.Text.Contains("DateSignature"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(DateSignature.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }


            }

            System.IO.Directory.CreateDirectory(env);

            //FormulaireBG.SaveAs2(FileName: @"" + env + "\\Mission_" + MissionNumber.Text + ".docx"); // Ceci est pour enregistrer sous format word
            
            FormulaireBG.ExportAsFixedFormat(@"" + env + "\\Mission_" + MissionNumber.Text + ".pdf", Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);

            MissionNumber.IsEnabled = false;
            
            application.ResetIgnoreAll();
            FormulaireVide = application.Documents.Add(Template: @"" + path + "\\Templates\\ModeleMission.docx");

            foreach (Microsoft.Office.Interop.Word.Field field in FormulaireVide.Fields)
            {

                if (field.Code.Text.Contains("NumMission"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(MissionNumber.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);

                    }

                }

                else if (field.Code.Text.Contains("LastN"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(MissionNom.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }

                else if (field.Code.Text.Contains("FirstN"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(MissionPrenom.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }

                else if (field.Code.Text.Contains("MissionPoste"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(MissionPoste.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }

                else if (field.Code.Text.Contains("MissionAdr"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(MissionAdresse.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }

                else if (field.Code.Text.Contains("LieuMission"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(LieuMission.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }

                else if (field.Code.Text.Contains("MotifMission"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(MotifMission.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }

                else if (field.Code.Text.Contains("MoyTransport"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(MoyenTransport.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }

                else if (field.Code.Text.Contains("DateSortieMission"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(DateSortieEnMission.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }

                else if (field.Code.Text.Contains("DateEntreeMission"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(DateEntreeDeMission.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }

                else if (field.Code.Text.Contains("TypeIdentité"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(TypeIdentite.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }

                else if (field.Code.Text.Contains("DateSignature"))
                {
                    try
                    {
                        field.Select();
                        application.Selection.TypeText(DateSignature.Text);
                    }
                    catch (Exception ex)
                    {
                        application.Quit();
                        MessageBox.Show(ex.Message);
                    }

                }


            }

            MessageBoxResult result = MessageBox.Show("Voulez vous imprimer le formulaire ?\n ", "Question ?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    //application.Visible = true;  // Décommenter si vous voulez afficher le formulaire en cas de réponse "OUI"
                    application.PrintOut();
                    application.Quit(false);
                    break;

                case MessageBoxResult.No:
                    application.Quit(false);

                    break;

            }

        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Êtes-vous sûre de réinitialiser le formulaire ?\n ", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            switch (result)
            {
                case MessageBoxResult.Yes:

                    MainWindow newWindow = new MainWindow();
                    newWindow.Show();
                    this.Close();

                    break;

                case MessageBoxResult.No:

                    MessageBox.Show("Vous avez annuler la réinitialisation","Annulation",MessageBoxButton.OK,MessageBoxImage.Information);

                    break;

            }

            
        }

        
        private void MissionNumber_GotFocus(object sender, RoutedEventArgs e)
        {
            if (MissionNumber.Text == "رقم")
            {
                MissionNumber.Text = "";
            }
            
        }

        private void MissionNumber_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (MissionNumber.Text == "" || TypeIdentite.Text == null)
            {
                MissionNumber.Text = "رقم";
            }
        }

        private void MissionNom_GotFocus(object sender, RoutedEventArgs e)
        {
            if (MissionNom.Text == "اللقب")
            {
                MissionNom.Text = "";
            }
            
        }

        private void MissionNom_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (MissionNom.Text == "" || MissionNom.Text == null)
            {
                MissionNom.Text = "اللقب";
            }
        }

        private void MissionPrenom_GotFocus(object sender, RoutedEventArgs e)
        {
            if (MissionPrenom.Text == "الاسم")
            {
                MissionPrenom.Text = "";
            }
            
        }

        private void MissionPrenom_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (MissionPrenom.Text == "" || MissionPrenom.Text == null)
            {
                MissionPrenom.Text = "الاسم";
            }
        }

        private void MissionPoste_GotFocus(object sender, RoutedEventArgs e)
        {
            if (MissionPoste.Text == "الوظيفة")
            {
                MissionPoste.Text = "";
            }
            
        }

        private void MissionPoste_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (MissionPoste.Text == "" || MissionPoste.Text == null)
            {
                MissionPoste.Text = "الوظيفة";
            }
        }


        private void MissionAdresse_GotFocus(object sender, RoutedEventArgs e)
        {
            if (MissionAdresse.Text == "السكن")
            {
                MissionAdresse.Text = "";
            }
            
        }

        private void MissionAdresse_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (MissionAdresse.Text == "" || MissionAdresse.Text == null)
            {
                MissionAdresse.Text = "السكن";
            }
        }

        private void LieuMission_GotFocus(object sender, RoutedEventArgs e)
        {
            if (LieuMission.Text == "يسافر إلى")
            {
                LieuMission.Text = "";
            }
            
        }

        private void LieuMission_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (LieuMission.Text == "" || LieuMission.Text == null)
            {
                LieuMission.Text = "يسافر إلى";
            }
        }

        private void MotifMission_GotFocus(object sender, RoutedEventArgs e)
        {
            if (MotifMission.Text == "سبب السفر")
            {
                MotifMission.Text = "";
            }
           
        }

        private void MotifMission_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (MotifMission.Text == "" || MotifMission.Text == null)
            {
                MotifMission.Text = "سبب السفر";
            }
        }

        private void MoyenTransport_GotFocus(object sender, RoutedEventArgs e)
        {
            if (MoyenTransport.Text == "إمكانيات النقل")
            {
                MoyenTransport.Text = "";
            }
            
        }

        private void MoyenTransport_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (MoyenTransport.Text == "" || MoyenTransport.Text == null)
            {
                MoyenTransport.Text = "إمكانيات النقل";
            }
        }

        private void TypeIdentite_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TypeIdentite.Text == "نوع وصفة التعريف")
            {
                TypeIdentite.Text = "";
            }
            
        }

        private void TypeIdentite_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (TypeIdentite.Text == "" || TypeIdentite.Text == null)
            {
                TypeIdentite.Text = "نوع وصفة التعريف";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            About newWindow = new About();
            newWindow.Show();
        }
    }
}
