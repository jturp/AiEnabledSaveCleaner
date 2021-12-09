using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace AiEnabledSaveCleaner
{
  public partial class AiECleaner : Form
  {
    readonly FolderBrowserDialog folderDialog = new FolderBrowserDialog();

    public AiECleaner()
    {
      InitializeComponent();
    }

    private void AiECleaner_Load(object sender, EventArgs e)
    {
      MinimumSize = Size;
      folderDialog.RootFolder = Environment.SpecialFolder.ApplicationData;
      folderDialog.ShowNewFolderButton = false;

      LblInstruction.Text = @"Instructions:

Enter or browse to your World Save Folder, then select Clean to fix the SBC file.
Once complete, load your world and enjoy!

Example: %AppData%\SpaceEngineers\Saves\12345\MyCoolWorldName
Or:   C:\Users\jTurp\AppData\Roaming\Saves\12345\MyCoolWorldName";
    }

    private void BtnBrowse_Click(object sender, EventArgs e)
    {
      folderDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\SpaceEngineers\Saves\";
      folderDialog.ShowDialog();

      var path = folderDialog.SelectedPath;
      TBoxFileInput.Text = path;
    }

    private void BtnClean_Click(object sender, EventArgs e)
    {
      var path = Environment.ExpandEnvironmentVariables(TBoxFileInput.Text);
      var sbc = path + @"\Sandbox.sbc";

      if (File.Exists(sbc))
      {
        if (CleanSBC(sbc))
        {
          var other = path + @"\SANDBOX_0_0_0_.sbsB5";

          if (File.Exists(other))
          {
            File.Delete(other);
          }
        }
      }
      else
      {
        MessageBox.Show("There was no file named 'Sandbox.sbc' in the specified directory");
      }
    }

    bool CleanSBC(string path)
    {
      var xmlDoc = new XmlDocument();
      xmlDoc.Load(path);

      var nodes = xmlDoc.GetElementsByTagName("MyObjectBuilder_Identity");
      var total = nodes.Count;
      int count = 0;

      for (int i = nodes.Count - 1; i >= 0; i--)
      {
        var node = nodes[i];
        var children = node.ChildNodes;

        bool nameFound = false;
        string name = "";
        long id = -1;

        for (int j = 0; j < children.Count; j++)
        {
          var child = children[j];
          if (child.Name == "IdentityId")
          {
            long.TryParse(child.InnerText, out id);
          }
          else if (child.Name == "DisplayName")
          {
            name = child.InnerText;
            nameFound = true;
          }

          if (nameFound && id > 0)
          {
            break;
          }
        }

        if (id > 0 && nameFound && (string.IsNullOrWhiteSpace(name) || name.Equals("wolf", StringComparison.OrdinalIgnoreCase)))
        {
          count++;
          var item = $"{id}: {name}";
          if (!LBoxResult.Items.Contains(item))
            LBoxResult.Items.Add(item);

          node.ParentNode.RemoveChild(node);
        }
      }

      if (count > 0)
      {
        LBoxResult.Size = LBoxResult.PreferredSize;
        xmlDoc.Save(path);
      }

      LblResult.Text = $"Finished cleaning SBC. Removed {count} of {total} entries.";

      return count > 0;
    }
  }
}
