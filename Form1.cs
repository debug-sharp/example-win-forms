using Desharp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExampleWinForms {
	public partial class Form1: Form {
		public Form1() {
			InitializeComponent();

			this._demoDumpAndLog();
			this._demoException();
		}

		private void _demoDumpAndLog() {
			var demoObject = new Dictionary<string, object>() {
				{ "clark", new {
					name = "Clark",
					surname = "Kent",
					tshirtIdol = "chuck"
				} },
				{ "chuck", new {
					name = "Chuck",
					surname = "Noris",
					tshirtIdol = "bud"
				} },
				{ "bud", new {
					name = "Bud",
					surname = "Spencer",
					tshirtIdol = ""
				} }
			};

            this.output.Text += Debug.Dump(demoObject, new DumpOptions {
                Return = true,
                SourceLocation = true
            });
			this.output.Text += Environment.NewLine + Environment.NewLine;

			Debug.Dump(demoObject);
			Debug.Log(demoObject);
		}

		private void _demoException () {
			try {
				throw new Exception("Demo exception:-)");
			} catch (Exception ex) {
				this.output.Text += Debug.Dump(ex, new DumpOptions {
					Return = true,
					SourceLocation = true
				});
				Debug.Dump(ex);
				Debug.Log(ex);
			}
		}
	}
}
