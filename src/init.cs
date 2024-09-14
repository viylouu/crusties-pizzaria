partial class crust {
    static void init() {
        Window.Title = "crustie's pizzaria";
        Simulation.SetFixedResolution(640,360,Color.Black,false,false,true);

        loadvehicles();
    }

    static void loadvehicles() {
        string[] files = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\assets\spritestacks\vehicles\", "*.png");

        for (int i = 0; i < files.Length; i++) {
            ITexture _tex = Graphics.LoadTexture(files[i]);
            vehicles.Add(new vehicle() { tex = _tex, name = Path.GetFileNameWithoutExtension(files[i]), layers = _tex.Width/_tex.Height });
            _tex.Dispose();
        }
    }
}