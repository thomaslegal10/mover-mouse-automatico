using System.Runtime.InteropServices;

namespace Mover_mouse_automático
{
    public static class VirtualTeclado
    {
        [DllImport("user32.dll", EntryPoint = "keybd_event", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern void Keybd_event(byte vk, byte scan, int flags, int extrainfo);

        public static void PressKey(VirtualKeyCodes keyCode)
        {
            const int KEYEVENTF_EXTENDEDKEY = 0x1;
            const int KEYEVENTF_KEYUP = 0x2;
            const int KEYEVENTF_KEYDOWN = 0x0;

            byte KeyCode = (byte)keyCode;

            Keybd_event(KeyCode, 0x45, KEYEVENTF_KEYDOWN | KEYEVENTF_EXTENDEDKEY, 0);
            Keybd_event(KeyCode, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }
    }
}