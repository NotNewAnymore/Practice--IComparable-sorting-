namespace Practice__IComparable_sorting_
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();
			List<Bullet> bullets = new List<Bullet>();
			for (int i = 0; i < 50; i++)
			{
				bullets.Add(new Bullet(random.Next(-4096, 4096), random.Next(-500, 500), random.Next(-1000, 1000)));
			}
			Console.WriteLine("Unsorted");
			foreach (Bullet bullet in bullets)
			{
				Console.WriteLine($"Bullet at layer {bullet.layer}, position {bullet.xpos},{bullet.ypos}.");
			}

			bullets.Sort();
			Console.WriteLine("Sorted - basic");
			foreach (Bullet bullet in bullets)
			{
				Console.WriteLine($"Bullet at layer {bullet.layer}, position {bullet.xpos},{bullet.ypos}.");
			}

			bullets.Sort(new Bulletsorter_LayerDesc());
			Console.WriteLine("Sorted - reverse");
			foreach (Bullet bullet in bullets)
			{
				Console.WriteLine($"Bullet at layer {bullet.layer}, position {bullet.xpos},{bullet.ypos}.");
			}

			bullets.Sort(new BulletSorterSoPosAsc());
			Console.WriteLine("Sorted - Position Ascending");
			foreach (Bullet bullet in bullets)
			{
				Console.WriteLine($"Bullet at layer {bullet.layer}, position {bullet.xpos},{bullet.ypos}.");
			}
		}
	}
}