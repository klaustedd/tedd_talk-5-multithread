using MultiThreading.Async;
using MultiThreading.DAO;
using MultiThreading.DAO.Cached;
using MultiThreading.Models;

namespace MultiThreading
{
    public partial class Form : System.Windows.Forms.Form
    {
        /// <summary>
        /// DAO para acessar os dados dos jogadores
        /// </summary>
        private IPlayerDAO _playerDAO;

        /// <summary>
        /// Armazena os dados da pagina��o atual
        /// </summary>
        private Pagination _playersPagination;

        /// <summary>
        /// Armazena o n�mero m�ximo de jogadores por p�gina
        /// </summary>
        private const int MaxPlayersPerPage = 20;

        /// <summary>
        /// Armazena os jogadores que ser�o exibidos
        /// </summary>
        ICollection<Player> _playersList;

        public Form()
        {
            InitializeComponent();

            //Criando a DAO e um objeto de pagina��o que ser� utilizado para obter os dados paginados da DAO
            _playerDAO = new PlayerCachedDAO();
            _playersPagination = _playerDAO.PaginationOfAll(MaxPlayersPerPage);

            // TODO Obter os dados dos jogadores atrav�s da DAO e a pagina��o
            
            DrawGrid();
            UpdateStatusLabel(_playersPagination.CurrentPage, _playersPagination.TotalPages);
        }

        private void UpdateStatusLabel(uint currentPage, uint totalPages)
        {
            tsslPaginacao.Text = $"Pagina {currentPage}/{totalPages}";
        }

        private void DrawGrid()
        {
            dataGridView.Rows.Clear();
            foreach (var (player, i) in _playersList.Select((value, i) => (value, i)))
            {
                var rowContent = new string[5]
                {
                    player.Name,
                    player.Height.ToString(),
                    player.Weight.GetValueOrDefault(0).ToString(),
                    player.Team,
                    player.Position,
                };
                dataGridView.Rows.Add(rowContent);
            }
        }

        private void tssbAvancar_ButtonClick(object sender, EventArgs e)
        {
            // TODO fazer este bot�o funcionar
        }

        private void tssbVoltar_ButtonClick(object sender, EventArgs e)
        {
            // TODO fazer este bot�o funcionar
        }

        private void tssbModoAutomatico_ButtonClick(object sender, EventArgs e)
        {
            // TODO fazer este bot�o funcionar
        }
    }
}