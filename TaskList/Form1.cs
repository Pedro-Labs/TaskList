namespace TaskList
{
    public partial class Form1 : Form
    {
        List<Task> tasks = new List<Task>();

        private void RefreshDataGridView()
        {
            GridTasks.DataSource = null;  // Limpar o DataSource
            GridTasks.DataSource = tasks;  // Definir a nova lista de tarefas como DataSource
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            // Criar uma nova tarefa com o nome "Nova Tarefa" e estado n�o conclu�do
            Task newTask = new Task
            {
                Nome = "Nova Tarefa",
                Completa = false
            };

            // Adicionar a nova tarefa � lista
            tasks.Add(newTask);

            // Atualizar o DataGridView para refletir as altera��es
            RefreshDataGridView();
        }

        private void btnMarkAsCompleted_Click(object sender, EventArgs e)
        {
            // Verificar se alguma tarefa est� selecionada no DataGridView
            if (GridTasks.SelectedRows.Count > 0)
            {
                // Obter o �ndice da linha selecionada
                int selectedIndex = GridTasks.SelectedRows[0].Index;

                // Marcar a tarefa como conclu�da (alterar o valor "Completa")
                tasks[selectedIndex].Completa = true;

                // Atualizar o DataGridView para refletir as altera��es
                RefreshDataGridView();
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            // Verificar se alguma tarefa est� selecionada no DataGridView
            if (GridTasks.SelectedRows.Count > 0)
            {
                // Obter o �ndice da linha selecionada
                int selectedIndex = GridTasks.SelectedRows[0].Index;

                // Remover a tarefa da lista
                tasks.RemoveAt(selectedIndex);

                // Atualizar o DataGridView para refletir as altera��es
                RefreshDataGridView();
            }
        }
    }
}
