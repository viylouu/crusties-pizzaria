partial class crust {
    static List<spritestack> stacks = new();

    static void addstack(spritestack ss) => stacks.Add(ss);

    static void renderstack(ICanvas c, Vector2 camera, float camz, float camrot) {
        List<spritestack> _sorted = new();

        Parallel.ForEach(stacks, ss => {
            _sorted.Add(ss);
        });

        //apply "depth sorting"
        _sorted.Sort((a, b) => {
            if (b.z.CompareTo(a.z) != 0)
                return -b.z.CompareTo(a.z);
            else {
                float cosRot = MathF.Cos(camrot);
                float sinRot = MathF.Sin(camrot);
                float aTransY = (a.pos.X - camera.X) * sinRot + (a.pos.Y - camera.Y) * cosRot;
                float bTransY = (b.pos.X - camera.X) * sinRot + (b.pos.Y - camera.Y) * cosRot;
                return aTransY.CompareTo(bTransY);
            }
        });

        foreach (var ss in _sorted) {
            for (int i = 0; i < ss.layers; i++) {
                //epic transformation
                c.Translate(0,-i-ss.z);
                c.Translate(-camera.X, -camera.Y);
                c.Rotate(-camrot);
                c.Translate(ss.pos.X, ss.pos.Y);
                c.Rotate(ss.rot);

                c.DrawTexture(
                    ss.tex,
                    new Rectangle(i*16,0,16,16),
                    new Rectangle(0,0,16,16,Alignment.Center)
                );
                c.ResetState();
            }

            c.Flush();
        }

        stacks.Clear();
    }
}