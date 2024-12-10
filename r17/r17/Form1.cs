using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace r17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional logic for form load
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OSVersion.GetMajorVersion() == 6)
            {
                SimpleTaskDialog.Show(this,
                    "TaskDialog can be used in Windows Vista.",
                    "Your computer is running Windows Vista.",
                    "TaskDialog Demo",
                    SimpleTaskDialog.TaskDialogButtons.Yes,
                    SimpleTaskDialog.TaskDialogIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "TaskDialog is only supported on Windows Vista or later.",
                    "TaskDialog Demo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }

    class SimpleTaskDialog
    {
        [DllImport("comctl32.dll", CharSet = CharSet.Unicode, EntryPoint = "TaskDialog")]
        static extern int _TaskDialog(IntPtr hWndParent, IntPtr hInstance, string pszWindowTitle,
            string pszMainInstruction, string pszContent, int dwCommonButtons, IntPtr pszIcon, out int pnButton);

        [Flags]
        public enum TaskDialogButtons
        {
            OK = 0x0001,
            Cancel = 0x0008,
            Yes = 0x0002,
            No = 0x0004,
            Retry = 0x0010,
            Close = 0x0020
        }

        public enum TaskDialogIcon
        {
            Information = UInt16.MaxValue - 2,
            Warning = UInt16.MaxValue,
            Stop = UInt16.MaxValue - 1,
            Question = 0,
            SecurityWarning = UInt16.MaxValue - 5,
            SecurityError = UInt16.MaxValue - 6,
            SecuritySuccess = UInt16.MaxValue - 7,
            SecurityShield = UInt16.MaxValue - 3,
            SecurityShieldBlue = UInt16.MaxValue - 4,
            SecurityShieldGray = UInt16.MaxValue - 8
        }

        public enum TaskDialogResult
        {
            None, OK, Cancel, Yes, No, Retry, Close
        }

        private static TaskDialogResult ShowInternal(IntPtr owner, string text, string instruction,
            string caption, TaskDialogButtons buttons, TaskDialogIcon icon)
        {
            int p;
            if (_TaskDialog(owner, IntPtr.Zero, caption, instruction, text, (int)buttons, new IntPtr((int)icon), out p) != 0)
                throw new InvalidOperationException("Error occurred while displaying TaskDialog.");

            return p switch
            {
                1 => TaskDialogResult.OK,
                2 => TaskDialogResult.Cancel,
                4 => TaskDialogResult.Retry,
                6 => TaskDialogResult.Yes,
                7 => TaskDialogResult.No,
                8 => TaskDialogResult.Close,
                _ => TaskDialogResult.None
            };
        }

        public static TaskDialogResult Show(IWin32Window owner, string text) =>
            Show(owner, text, null, null, TaskDialogButtons.OK);

        public static TaskDialogResult Show(IWin32Window owner, string text, string instruction) =>
            Show(owner, text, instruction, null, TaskDialogButtons.OK, 0);

        public static TaskDialogResult Show(IWin32Window owner, string text, string instruction, string caption) =>
            Show(owner, text, instruction, caption, TaskDialogButtons.OK, 0);

        public static TaskDialogResult Show(IWin32Window owner, string text, string instruction,
            string caption, TaskDialogButtons buttons) =>
            Show(owner, text, instruction, caption, buttons, 0);

        public static TaskDialogResult Show(IWin32Window owner, string text, string instruction,
            string caption, TaskDialogButtons buttons, TaskDialogIcon icon) =>
            ShowInternal(owner.Handle, text, instruction, caption, buttons, icon);

        public static TaskDialogResult Show(string text) =>
            Show(text, null, null, TaskDialogButtons.OK);

        public static TaskDialogResult Show(string text, string instruction) =>
            Show(text, instruction, null, TaskDialogButtons.OK, 0);

        public static TaskDialogResult Show(string text, string instruction, string caption) =>
            Show(text, instruction, caption, TaskDialogButtons.OK, 0);

        public static TaskDialogResult Show(string text, string instruction, string caption,
            TaskDialogButtons buttons) =>
            Show(text, instruction, caption, buttons, 0);

        public static TaskDialogResult Show(string text, string instruction, string caption,
            TaskDialogButtons buttons, TaskDialogIcon icon) =>
            ShowInternal(IntPtr.Zero, text, instruction, caption, buttons, icon);
    }

    class OSVersion
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct OSVERSIONINFO
        {
            public int dwOSVersionInfoSize;
            public int dwMajorVersion;
            public int dwMinorVersion;
            public int dwBuildNumber;
            public int dwPlatformId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szCSDVersion;
        }

        [DllImport("kernel32.Dll")]
        public static extern short GetVersionEx(ref OSVERSIONINFO o);

        public static string GetOSVersionInfo()
        {
            OSVERSIONINFO os = new OSVERSIONINFO
            {
                dwOSVersionInfoSize = Marshal.SizeOf(typeof(OSVERSIONINFO))
            };
            GetVersionEx(ref os);
            return $"{os.dwMajorVersion}.{os.dwMinorVersion}";
        }

        public static int GetMajorVersion()
        {
            OSVERSIONINFO os = new OSVERSIONINFO
            {
                dwOSVersionInfoSize = Marshal.SizeOf(typeof(OSVERSIONINFO))
            };
            GetVersionEx(ref os);
            return os.dwMajorVersion;
        }

        public static int GetMinorVersion()
        {
            OSVERSIONINFO os = new OSVERSIONINFO
            {
                dwOSVersionInfoSize = Marshal.SizeOf(typeof(OSVERSIONINFO))
            };
            GetVersionEx(ref os);
            return os.dwMinorVersion;
        }
    }
}
