partial class crust {
    static void rend(ICanvas c) {
        c.Clear(Color.Black);

        int vehic = roundi(Time.TotalTime*4) % vehicles.Count;

        addstack(
            new spritestack() { 
                tex = vehicles[vehic].tex, 
                layers = vehicles[vehic].layers, 
                outlined = false, 
                pos = new(0,4), 
                rot = 0,
                z = 0 
            }
        );

        addstack(
            new spritestack() { 
                tex = vehicles[vehic].tex, 
                layers = vehicles[vehic].layers, 
                outlined = false, 
                pos = new(0,-4), 
                rot = 0, 
                z = 0 
            }
        );

        renderstack(c, new(Window.Width/-2,Window.Height/-2),0,Time.TotalTime);
    }
}