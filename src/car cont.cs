partial class crust {
    static Vector2 carpos;
    static float carrot;
    static float rotvel;
    static Vector2 vel;
    static float fvel;
    static float accel = 48;
    static float deccel = 12.4f;
    static float friction = 18;
    static float maxspd = 12;

    static void movecar() {
        if (Keyboard.IsKeyDown(Key.W))
            fvel += accel * Time.DeltaTime;
        if (Keyboard.IsKeyDown(Key.S))
            fvel -= accel * Time.DeltaTime;

        if (fvel > 0)
            fvel -= deccel * Time.DeltaTime;
        if (fvel < 0)
            fvel += deccel * Time.DeltaTime;

        fvel = clamp(fvel, -maxspd, maxspd);

        vel += fvel * new Vector2(cos(carrot), sin(carrot)) * Time.DeltaTime*3;

        //vel *= .98f * Time.DeltaTime * 60;

        carpos += vel * Time.DeltaTime * 35;

        carrot += rotvel * Time.DeltaTime * 25;

        //damping through subtraction of vel
        if (vel.X > 0)
            vel.X -= friction * Time.DeltaTime;
        if (vel.X < 0)
            vel.X += friction * Time.DeltaTime;
        if(vel.Y > 0)
            vel.Y -= friction * Time.DeltaTime;
        if (vel.Y < 0)
            vel.Y += friction * Time.DeltaTime;
    }
}