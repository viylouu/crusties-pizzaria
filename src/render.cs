partial class crust {
    static void rend(ICanvas c) {
        c.Clear(Color.Black);

        addstack(
            new() { 
                tex = vehicles[0].tex, 
                layers = vehicles[0].layers, 
                outlined = false, 
                pos = new(0,0), 
                rot = 0, 
                z = 0 
            }
        );

        renderstack(c, new(Window.Width/-2,Window.Height/-2),0,Time.TotalTime);

        rendertext(c, dfont, $"{round(1/Time.DeltaTime)} fps", new(3,3), Color.White);
    }
}