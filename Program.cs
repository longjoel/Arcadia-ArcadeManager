// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;

namespace Arcadia
{
    public enum ProgramMode
    {
        Edge = 0,
        Server = 1,
        Console = 2,
    }

    public class EdgeOptions
    {
        public Uri? ServerHost { get; set; } = new Uri("http://localhost:8080");
    }
    public class ProgramOptions
    {
        // Take the default value, then from the environment, override with command line args




        /// <summary>
        /// Program Mode: How the program should run.
        /// /// - Edge: Runs in Edge mode, connecting to a server.
        /// /// - Server: Runs as a server.
        /// /// - Console: Runs in console mode, suitable for local execution.
        /// </summary>

        public ProgramMode Mode { get; set; } = ProgramMode.Console;


        public EdgeOptions? Edge { get; set; } = null;


    }
    public class Program
    {

        ProgramOptions _options;
        public Program(ProgramOptions options)
        {
            // Constructor logic can go here if needed
            _options = options;
        }

        public static ProgramOptions ParseArgs(string[] args)
        {
            // Here you can implement argument parsing logic
            // For now, we will just return a new instance of ProgramOptions
            return new ProgramOptions();
        }

        public static void Main(string[] args)
        {

        }

    }
}