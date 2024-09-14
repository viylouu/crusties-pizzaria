partial class crust {
    static void Main() {
        Simulation sim = Simulation.Create(init, rend);
        sim.Run();
    }
}