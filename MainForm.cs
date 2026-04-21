using ProductionLineControl.Enums;
using ProductionLineControl.Forms;
using ProductionLineControl.Models;
using ProductionLineControl.Services;

namespace ProductionLineControl
{
    public partial class MainForm : Form
    {
        private readonly MotorService _motorService = new();

        private BindingSource _bindingSource = new();

        private readonly ConnectionManager _connectionManager = new();

        public MainForm()
        {
            InitializeComponent();

            this.Size = new Size(1600, 800);

            _bindingSource.DataSource = _motorService.GetAll();
            dgvMotors.DataSource = _bindingSource;
        }

        private void RefreshGrid()
        {
            _bindingSource.ResetBindings(false);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new MotorEditForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                _motorService.Add(form.Motor);
                _connectionManager.CreateConnection(form.Motor);
                RefreshGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMotors.CurrentRow?.DataBoundItem is not Motor motor)
                return;

            var form = new MotorEditForm(motor);

            if (form.ShowDialog() == DialogResult.OK)
            {
                _motorService.Update(form.Motor);
                RefreshGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMotors.CurrentRow?.DataBoundItem is not Motor motor)
                return;

            _motorService.Delete(motor.Id);
            _connectionManager.Disconnect(motor);
            RefreshGrid();
        }

        private readonly RecipeService _recipeService = new();

        private void btnLoadRecipe_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            var recipe = _recipeService.Load(dialog.FileName);

            if (recipe == null)
                return;

            foreach (var motor in recipe.Motors)
            {
                _motorService.Add(motor);
            }

            RefreshGrid();
        }

        private void btnSaveRecipe_Click(object sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog();

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            var recipe = new SpeedRecipe
            {
                Name = "Recipe " + DateTime.Now
            };

            recipe.Motors = _motorService.GetAll();

            _recipeService.Save(dialog.FileName, recipe);
        }

        private void dgvMotors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private readonly Random _random = new();

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var motor in _motorService.GetAll())
            {
                motor.CurrentSpeed = motor.TargetSpeed + _random.Next(-5, 5);
                motor.Current = _random.Next(1, 10);
                motor.Voltage = 220 + _random.Next(-10, 10);
                motor.Status = "Running";
            }

            RefreshGrid();
        }
    }
}
