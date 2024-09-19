partial class crust {
    static float pi = 3.141592653589f;
    static int round(int a) => (int)MathF.Round(a);
    static float round(float a) => MathF.Round(a);
    static int roundi(float a) => (int)MathF.Round(a);
    static float sin(float a) => MathF.Sin(a);
    static float cos(float a) => MathF.Cos(a);
    static float clamp(float a, float b, float c) => Math.Clamp(a,b,c);
    static float dtween(float a, float b, float c) => (b-a)/(c/(Time.DeltaTime*60));
    static Vector2 dtween(Vector2 a, Vector2 b, float c) => (b-a)/(c/(Time.DeltaTime*60));
}