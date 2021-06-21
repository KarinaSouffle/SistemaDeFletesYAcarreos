using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFletesAcarreoB.Vista
{
    public class MessageBoxAutoClose
    {
        const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll",
            CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true,
            CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter,
            string lpszClass, string lpszWindow);
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true,
            CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern bool SetWindowText(IntPtr hwnd, string lpString);

        private System.Threading.Timer tmrClose = null;
        private string
        title = string.Empty,
        message = string.Empty;
        private int secondsToClose;
        private IntPtr hndLabel = IntPtr.Zero;
        private bool showCountDown;
        private MessageBoxButtons msgButtons;
        private MessageBoxIcon msgIcon;
        static DialogResult msgResult;

        public MessageBoxAutoClose(string _message, string _title, MessageBoxButtons _msgButtons, MessageBoxIcon _msgIcon, int _secondsToClose, bool _showCountDown)
        {
            message = _message;
            title = _title;
            msgButtons = _msgButtons;
            msgIcon = _msgIcon;
            secondsToClose = (_secondsToClose > 99) ? 99 : _secondsToClose;
            showCountDown = _showCountDown;

            tmrClose = new System.Threading.Timer(m_execEverySecond, null, 1000, 1000);
            if (showCountDown)
            {
               DialogResult msgResult = MessageBox.Show(message + "\r\nEste mensaje se cerrará dentro de " +
                secondsToClose.ToString("00") + " segundos", title, msgButtons, msgIcon);
                if (msgResult == DialogResult.Yes)
                    tmrClose.Dispose();
            }
            else
            {
                msgResult = MessageBox.Show(message, title, msgButtons, msgIcon);
                if (msgResult == DialogResult.Yes)
                    tmrClose.Dispose();
            }
        }

        /// <summary>
        /// Permite mostrar el mensaje al usuario con los segundos para cerrar el mensaje.
        /// </summary>
        /// <param name=”_message”>Texto del mensaje.</param>
        /// <param name=”_title”>Titulo del mensaje.</param>
        /// <param name=”_msgButtons”>Botones para el mensaje.</param>
        /// <param name=”_msgIcon”>Icono del mensaje.</param>
        /// <param name=”_secondsToClose”>Segundos para cerrar el mensaje.</param>
        /// <param name=”_showCountDown”>true-> Mostrará los segundos para cerrar el mensaje.</param>
        public static DialogResult m_show(string _message, string _title, MessageBoxButtons _msgButtons, MessageBoxIcon _msgIcon, int _secondsToClose, bool _showCountDown)
        {
            new MessageBoxAutoClose(_message, _title, _msgButtons, _msgIcon, _secondsToClose, _showCountDown);
            return msgResult;
        }

        private void m_execEverySecond(object state)
        {
            secondsToClose--;
            if (secondsToClose <= 0)
            {
                IntPtr hndMBox = FindWindow(null, title);
                if (hndMBox != IntPtr.Zero)
                {
                    SendMessage(hndMBox, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                    tmrClose.Dispose();
                }
            }
            else if (showCountDown)
            {
                // Ha pasado un intervalo de 1 seg:
                if (hndLabel != IntPtr.Zero)
                {
                    SetWindowText(hndLabel, message +
                    "\r\nEste mensaje se cerrará dentro de " +
                    secondsToClose.ToString("00") + " segundos");
                }
                else
                {
                    IntPtr hndMBox = FindWindow(null, title);
                    if (hndMBox != IntPtr.Zero)
                    {
                        // Ha encontrado el MessageBox, busca ahora el texto

                        int lonji = IntPtr.Size;
                        hndLabel = FindWindowEx(hndMBox, IntPtr.Zero, "Static", null);
                        hndLabel = FindWindowEx(hndMBox, hndLabel, "Static", null);//Se vuelve a ejecutar el metodo FindwindowEx para hayar el label, de lo contrario se topará con el icono que tambien es “static”

                        if (hndLabel != IntPtr.Zero)
                        {
                            // Ha encontrado el texto
                            SetWindowText(hndLabel, message +
                            "\r\nEste mensaje se cerrará dentro de " +
                            secondsToClose.ToString("00") + " segundos");
                        }
                    }
                }
            }
        }
    }
}
