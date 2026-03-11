namespace PostManDesktop
{
    public partial class DashBord : Form
    {
        public DashBord()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // DashBord
            // 
            ClientSize = new Size(757, 559);
            Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "DashBord";
            Text = "Postman by avrum indig";
            ResumeLayout(false);

        }
    }
}
