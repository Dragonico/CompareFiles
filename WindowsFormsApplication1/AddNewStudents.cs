using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
  public partial class AddNewStudents : Form {
 
    public AddNewStudents() {
      InitializeComponent();
      
      var enumCombo  = Enum.GetValues(typeof(Course));
      this.chkList.DataSource = enumCombo; 
       
    }

    private void button1_Click(object sender, EventArgs e) {
      //List<Course> selected = new List<Course>();
      //var itemsChecked = chkList.CheckedItems;
      //foreach (var item in itemsChecked) {
      //  selected.Add((Course)item);
      //}
      //var student3 = new Student {
      //  FirstName = txtFirstName.Text,
      //  LastName = txtLastName.Text,
      //  Subjects = selected,
      //  Class = txtClass.Text,
      //  Age = Convert.ToInt32(txtAge.Text.Trim())
      //};
      //BusinessManager bm = new BusinessManager();
      //bm.Instantiate(student3);


     // openFileDialog1.ShowDialog();
      OpenFileDialog fileOpen = new OpenFileDialog();
      fileOpen.Title = "Open Image file";
      fileOpen.Filter = "JPG Files (*.jpg)| *.jpg";

      if (fileOpen.ShowDialog() == DialogResult.OK) {
        picImage.Image = Image.FromFile(fileOpen.FileName);
      }
      fileOpen.Dispose();
    }
  }
}
