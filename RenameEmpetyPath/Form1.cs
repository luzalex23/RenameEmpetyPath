namespace RenameEmpetyPath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void btnRenameEmptyFolders_Click_Click(object sender, EventArgs e)
        {
            
                // Seleciona a pasta raiz que deseja pesquisar
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                string rootPath = folderBrowserDialog.SelectedPath;

                // Recupera todos os nomes de diretórios no caminho especificado
                string[] directories = Directory.GetDirectories(rootPath);

                int renamedFoldersCount = 0;

                // Percorre cada nome de diretório
                foreach (string directory in directories)
                {
                    // Verifica se a pasta está vazia
                    if (Directory.GetFiles(directory).Length == 0 && Directory.GetDirectories(directory).Length == 0)
                    {
                        // Renomeia a pasta com um sufixo "_renamed"
                        string renamedDirectory = directory + "_renamed";
                        Directory.Move(directory, renamedDirectory);
                        renamedFoldersCount++;
                    }
                }

                // Exibe uma mensagem informando quantas pastas foram renomeadas
                MessageBox.Show(string.Format("{0} pastas vazias foram renomeadas.", renamedFoldersCount));
            
        }
    }
}