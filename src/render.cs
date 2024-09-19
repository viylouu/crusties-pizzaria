partial class crust {
    static void rend(ICanvas c) {
        c.Clear(Color.Black);

        movecar();

        addstack(
            new() { 
                tex = vehicles[0].tex, 
                layers = vehicles[0].layers, 
                outlined = false, 
                pos = carpos, 
                rot = carrot, 
                z = 0 
            }
        );

        camrot += dtween(camrot, -carrot, 4);
        campos += dtween(campos, -carpos, 4);

        renderstack(c, campos,0,Time.TotalTime);

        rendertext(c, dfont, $"{round(1/Time.DeltaTime)} fps", new(3,3), Color.White);
        rendertext(c, dfont, $"pos: {carpos}", new(3,3+(dfont.charh+2)), Color.White);
        rendertext(c, dfont, $"rot: {carrot}", new(3,3+(dfont.charh+2)*2), Color.White);
        rendertext(c, dfont, $"vel: {vel}", new(3,3+(dfont.charh+2)*3), Color.White);
        rendertext(c, dfont, $"angvel: {rotvel}", new(3,3+(dfont.charh+2)*4), Color.White);
        rendertext(c, dfont, $"fwdvel: {fvel}", new(3,3+(dfont.charh+2)*5), Color.White);
    }
}