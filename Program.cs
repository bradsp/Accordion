using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Opulos.Core.UI;

namespace AccordionDemo {
static class Program {
	[STAThread]
	static void Main() {
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run(new AccordionDemoForm());
	}
}
}
