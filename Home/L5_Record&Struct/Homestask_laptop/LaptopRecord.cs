using System;
namespace Homestask_laptop
{
	public record LaptopRecord
	{
        public int Ram { get; init; }
        public int CPU { get; init; }
        public string? Model { get; init; }
        public int Memory { get; init; }
        public Color Color { get; init; }

        public void On()
        { Console.WriteLine($"{Color} {Model} laptop turned on ! "); }

        public void Off()
        { Console.WriteLine($"{Color} {Model} laptop turned off ! "); }

        public void Restart()
        {
            Console.WriteLine($"{Color} {Model} laptop restarted ! ");
        }

	}
}

