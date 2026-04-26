namespace tpmodul9_103082400024.Model
{
    public class ModelMahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }

        public ModelMahasiswa(string nama, string nim)
        {
            Nama = nama;
            Nim = nim;
        }
    }
}
