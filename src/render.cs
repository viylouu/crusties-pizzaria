partial class crust {
    static void rend(ICanvas c) {
        c.Clear(Color.Black);

        int vehic = roundi(Time.TotalTime) % vehicles.Count;

        for (int i = 0; i < vehicles[vehic].layers; i++) {
            c.Translate(Window.Width/2,Window.Height/2-i);
            c.Rotate(Time.TotalTime);

            c.DrawTexture(
                vehicles[vehic].tex,
                new Rectangle(i*16,0,16,16),
                new Rectangle(0,0,16,16,Alignment.Center)
            );

            c.ResetState();
        }
    }
}