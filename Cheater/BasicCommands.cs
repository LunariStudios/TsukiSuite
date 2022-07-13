using System;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace Lunari.Tsuki.Cheater {
    public class ListCommandsCommand : Command {
        public ListCommandsCommand() : base("list_commands", "lscmd") { }

        public override void Invoke(CommandInvokation invokation, CommandOutput output) {
            var message = new StringBuilder();
            var cmds = CommandManager.Commands;
            message.AppendLine($"Commands ({cmds.Count}):");
            foreach (var command in cmds) {
                var header = new StringBuilder();
                header.Append(command.PrimaryAlias);
                var secondary = command.SecondaryAliases;
                if (!secondary.IsEmpty()) {
                    header.Append(" (");
                    header.Append(string.Join(", ", secondary));
                    header.Append(")");
                }

                header.Append(": ");
                var shortDescription = command.ShortDescription;
                if (shortDescription.IsNullOrEmpty()) {
                    header.Append("No description provided.");
                }
                else {
                    header.Append(shortDescription);
                }

                header.AppendLine();
                message.Append(header);
            }

            output.PrintLn(message);
        }
    }

    public class ScreenInfoCommand : Command {
        public ScreenInfoCommand() : base("screen_info") { }

        public override void Invoke(CommandInvokation invokation, CommandOutput output) {
            output.PrintLn($"Size: {Screen.height}x{Screen.width}");
            output.PrintLn(
                $"Current Resolution: {Screen.currentResolution.width}x{Screen.currentResolution.height}@{Screen.currentResolution.refreshRate}hz");
            output.PrintLn($"Safe Area: {Screen.safeArea}");
            output.PrintLn($"Brightness: {Screen.brightness}");
        }
    }

    public class EchoCommand : Command {
        private readonly StringArgument message;

        public EchoCommand() : base("echo") {
            ShortDescription = "Prints a message back to you.";
            message = AddStringArgument("message");
        }

        public override void Invoke(CommandInvokation invokation, CommandOutput output) {
            var t = invokation.Parse(message);
            output.PrintLn(t.Item1);
        }
    }

    public class TeleportCameraCommand : Command {
        public readonly IntArgument xArg;
        public readonly IntArgument yArg;
        public readonly IntArgument zArg;

        public TeleportCameraCommand() : base("teleport_camera", "tpcam") {
            ShortDescription = "Teleports the Camera.current camera to the given position";
            xArg = AddIntArgument("x", "Destination X coordinate");
            yArg = AddIntArgument("y", "Destination Y coordinate");
            zArg = AddIntArgument("z", "Destination Z coordinate");
        }

        public override void Invoke(CommandInvokation invokation, CommandOutput output) {
            var (x, y, z) = invokation.Parse(xArg, yArg, zArg);
            var cam = Camera.current;
            if (cam == null) {
                return;
            }

            cam.transform.position = new Vector3(x, y, z);
        }
    }

    public static class BasicCommands {
        [InitializeOnLoadMethod]
        public static void InitializeCommands() {
            CommandManager.Register(
                new ListCommandsCommand(),
                new ScreenInfoCommand(),
                new EchoCommand(),
                new TeleportCameraCommand()
            );
        }
    }
}