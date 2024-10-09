namespace MapPortingUtility.Forms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class IW3Settings : Form
    {
        public bool IncludeGenericSounds => includeGenericSoundsCheckbox.Checked;

        public bool ShouldConvertGSCs => convertGscsCheckbox.Checked;
        public bool ShouldConvertSpeculars => correctSpecularsCheckbox.Checked;

        public int SModelsFixMethod => smodelsFixComboBox.SelectedIndex;

        public bool ShouldAddCarePackages => this.addCarePackagesCheckbox.Checked;

        public bool ShouldExtendCulling => this.extendCullingDistanceCheckbox.Checked;

        public bool ShouldReplaceWithMiniguns => this.convertTurretsToMinigunsCheckbox.Checked;

        public bool ShouldRaiseCeiling => this.raiseCeilingCheckbox.Checked;

        public IW3Settings()
        {
            InitializeComponent();
            smodelsFixComboBox.SelectedIndex = 2;
            SetupTooltips();
        }

        private void SetupTooltips()
        {
            new ToolTip().SetToolTip(convertGscsCheckbox, "Attempt to automatically upgrade GSC from iw3 functions to iw4 equivalents and fix fog/specular calls");
            new ToolTip().SetToolTip(correctSpecularsCheckbox, "Aggressively tone down the specular images to correspond to iw4's grading");
            new ToolTip().SetToolTip(addCarePackagesCheckbox, "Modifies the clipmap to add two care packages as required by iw4. Should be harmless.");
            new ToolTip().SetToolTip(includeGenericSoundsCheckbox, "Add a bunch of generic sounds to the zone - this increases the size of the map but ensures most sounds will be present");
            new ToolTip().SetToolTip(smodelsFixComboBox, "Some iw3 models cannot be used as static models on iw4. IW3xport will attempt to move them to entities instead, unless you pick \"Leave as is\". Models can be either removed from GfxWorld (best, but can sometimes cause visibility issues) or swapped around GfxWorld (worse, but safer)");
        }
    }
}
