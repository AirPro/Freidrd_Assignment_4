using OrderDetailsMaintenance.Models.DataLayer;

namespace OrderDetailsMaintenance
{
    public partial class frmCustomerMaintenance : Form
    {
        public NorthwindContext _context;
        public OrderOptions _orderOptions;

        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCustomerMaintenance_Load(object sender, EventArgs e)
        {
            _context = new NorthwindContext();
            _orderOptions = _context.OrderOptions.First();
        }
    }
}