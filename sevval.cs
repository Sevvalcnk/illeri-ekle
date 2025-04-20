namespace iller12
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            listil.Items.Add(txtil.Text);
            txtil.Clear();
        }

        private void txtil_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                listil.Items.Add(txtil.Text);
                txtil.Clear();
            }
        }

        private void btnileri_Click(object sender, EventArgs e)
        {
            List<object> secilenler = new List<object>();
            
            foreach(var item in listil.SelectedItems)
            {
                secilenler.Add(item);
                
                    
            }
            foreach(var item in secilenler)
            {
                listil2.Items.Add(item);
                listil.Items.Remove(item);

            }
            
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            List<object> secilenler = new List<object>();
            foreach(var item in listil2.SelectedItems)
            {
                secilenler.Add(item);
            }
            foreach(var item in secilenler)
            {
                listil.Items.Add(item);
                listil2.Items.Remove(item);
            }
        }
    }
}
