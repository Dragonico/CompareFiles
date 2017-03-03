using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void btnA_Click(object sender, EventArgs e) {
      OpenFileDialog fileOpenAzure = new OpenFileDialog();
      fileOpenAzure.Title = "Open Image file";
      fileOpenAzure.FileName = label5.Text;
      fileOpenAzure.Filter = "JPG Files (*.jpg)| *.jpg";
      fileOpenAzure.InitialDirectory = @"C:\Temp\AzureImg";

      if (fileOpenAzure.ShowDialog() == DialogResult.OK) {
         pbxA.Image = Image.FromFile(fileOpenAzure.FileName);
         txtAzure.Text = fileOpenAzure.FileName;

      }
      fileOpenAzure.Dispose();
    }

    private void btnB_Click(object sender, EventArgs e) {
      OpenFileDialog fileOpenLocal = new OpenFileDialog();
      fileOpenLocal.Title = "Open Image file";
      fileOpenLocal.Filter = "JPG Files (*.jpg)| *.jpg";
      fileOpenLocal.InitialDirectory = @"C:\Temp\SynergyImg";

      if (fileOpenLocal.ShowDialog() == DialogResult.OK) {
        pbxB.Image = Image.FromFile(fileOpenLocal.FileName);
        txtLocal.Text = fileOpenLocal.FileName;
        label5.Text = Path.GetFileNameWithoutExtension(txtLocal.Text);
        txtSynergyId.Text = label5.Text;
        string fileNameAzure = @"C:\Temp\AzureImg\" + label5.Text + ".jpg";
        GetAzureImage(fileNameAzure);

      }
      fileOpenLocal.Dispose();
    }

    private void GetAzureImage(string filename) {
      pbxA.Image = Image.FromFile(filename);
      txtAzure.Text = filename;
    }

    private void btnDB_Click(object sender, EventArgs e) {
      string id = txtSynergyId.Text;
      var client = new MongoClient();
      IMongoDatabase db = client.GetDatabase("synergy2");

      var collection = db.GetCollection<Player>("sport.players");
      var result = collection.Find(x => x.id == MongoDB.Bson.ObjectId.Parse(id)).ToList();
      try {
        if (result != null) {
          label1.Text = result.First().firstName;
          label2.Text = result.First().lastName;
          label3.Text = result.First().id.ToString();
        }
      } catch {
        label3.Text = "Could not find the id";
      }
    }

    private void btnCompareC_Click(object sender, EventArgs e) {
      OpenFileDialog fileOpenLocalC = new OpenFileDialog();
      fileOpenLocalC.Title = "Open Image file";
      fileOpenLocalC.Filter = "JPG Files (*.jpg)| *.jpg";
      fileOpenLocalC.InitialDirectory = @"C:\Temp\SynergyImg";

      if (fileOpenLocalC.ShowDialog() == DialogResult.OK) {
        pbxLocalC.Image = Image.FromFile(fileOpenLocalC.FileName);
        txtLocalC.Text = fileOpenLocalC.FileName;
        label6.Text = Path.GetFileNameWithoutExtension(txtLocalC.Text);
       // txtSynergyId.Text = label5.Text;
        string fileNameAzure = @"C:\Temp\AzureImg\" + label6.Text + ".jpg";
        GetAzureImageC(fileNameAzure);

      }
      fileOpenLocalC.Dispose();
    }
    private void GetAzureImageC(string filename) {
      pbxAzureC.Image = Image.FromFile(filename);
      txtAzureC.Text = filename;
    }
  }
}
