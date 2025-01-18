namespace YazarKitap.Presentation.Infrastruccture
{
    public class Helper
    {
        public static void Clear(Control.ControlCollection collection)
        {
            foreach (var item in collection)
            {
                if(item is TextBox) ((TextBox)item).Clear();
                if (item is DateTimePicker) ((DateTimePicker)item).Value = DateTime.Now;
                if (item is GroupBox) Clear(((GroupBox)item).Controls);
            }
        }
    }
}
