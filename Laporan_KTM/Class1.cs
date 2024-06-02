using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Laporan_KTM
{
    internal class LaporanKTM
    {
        public enum State
        {
            Start,
            MembuatLaporan,
            MengeditLaporan,
            Ketemu
        }

        public enum Trigger
        {
            proses,
            cancel,
            cari,
            edit
        }

        public class StateTodo
        {
            public class Transition
            {
                public State StateAwal;
                public State StateAkhir;
                public Trigger Trigger;

                public Transition(State stateAwal, State stateAkhir, Trigger trigger)
                {
                    this.StateAwal = stateAwal;
                    this.StateAkhir = stateAkhir;
                    this.Trigger = trigger;
                }
            }

            private Transition[] transisi =
            {
                new Transition(State.Start, State.MembuatLaporan, Trigger.proses),
                new Transition(State.MembuatLaporan, State.Ketemu, Trigger.cari),
                new Transition(State.MembuatLaporan, State.Start, Trigger.cancel),
                new Transition(State.MembuatLaporan, State.MengeditLaporan, Trigger.edit),
                new Transition(State.MengeditLaporan, State.MembuatLaporan, Trigger.proses)
            };

            public State currentState = State.Start;
            public Dictionary<string, State> tasks = new Dictionary<string, State>();

            public State GetNextState(State stateAwal, Trigger trigger)
            {
                foreach (Transition perubahan in transisi)
                {
                    if (stateAwal == perubahan.StateAwal && trigger == perubahan.Trigger)
                    {
                        return perubahan.StateAkhir;
                    }
                }
                return stateAwal;
            }

            public void ActivateTrigger(Trigger trigger)
            {
                State newState = GetNextState(currentState, trigger);
                Console.WriteLine("State Anda adalah: " + newState);

                foreach (var ktm in tasks.ToList())
                {
                    if (ktm.Value == currentState)
                    {
                        tasks[ktm.Key] = newState;
                    }
                }

                currentState = newState;
            }

            public void AddTask(string task, State taskState)
            {
                tasks.Add(task, taskState);
                Console.WriteLine("Tambah task: " + task + " (State: " + taskState + ")");
            }

            public void DisplayTasks()
            {
                Console.WriteLine("Daftar task:");
                foreach (var task in tasks)
                {
                    Console.WriteLine("- " + task.Key + " (State: " + task.Value + ")");
                }
            }

            public void ChangeTaskState(string task, State newState)
            {
                if (tasks.ContainsKey(task))
                {
                    tasks[task] = newState;
                    Console.WriteLine("Task '" + task + "' berhasil diubah menjadi: " + newState);
                }
                else
                {
                    Console.WriteLine("Task '" + task + "' tidak ditemukan.");
                }
            }

            public void AddTasks()
            {
                Console.Write("Masukkan jumlah task yang ingin ditambahkan: ");
                int jumlahTask = int.Parse(Console.ReadLine());
                Debug.Assert(jumlahTask >= 0, "Jumlah task tidak boleh negatif");

                for (int i = 0; i < jumlahTask; i++)
                {
                    Console.Write("Masukkan nama task ke-" + (i + 1) + ": ");
                    string namaTask = Console.ReadLine();
                    AddTask(namaTask, State.Start);
                }
            }

            public void Run()
            {
                Console.WriteLine("Daftar trigger yang tersedia:");
                foreach (Trigger trigger in Enum.GetValues(typeof(Trigger)))
                {
                    Console.WriteLine("- " + trigger);
                }

                Console.WriteLine();
                AddTasks(); // Call the new AddTasks method to handle task addition

                DisplayTasks();

                do
                {
                    Console.Write("Masukkan nama task yang ingin diubah statusnya atau ketik 'stop' untuk menghentikan: ");
                    string taskYangDiubah = Console.ReadLine();

                    if (taskYangDiubah.ToLower() == "stop")
                    {
                        break; // Menghentikan loop jika pengguna memasukkan "stop"
                    }

                    Console.WriteLine("Daftar trigger yang tersedia:");
                    foreach (Trigger trigger in Enum.GetValues(typeof(Trigger)))
                    {
                        Console.WriteLine("- " + trigger);
                    }

                    Console.WriteLine();

                    Console.Write("Pilih trigger untuk task '" + taskYangDiubah + "': ");
                    string triggerInput = Console.ReadLine();

                    if (Enum.TryParse(triggerInput, out Trigger selectedTrigger))
                    {
                        ActivateTrigger(selectedTrigger);
                        DisplayTasks(); // Perbarui tampilan setelah mengaktifkan trigger

                        // Periksa apakah tugas selesai (berada dalam status Ketemu), jika iya, panggil metode Bayar()
                        if (tasks.ContainsKey(taskYangDiubah) && tasks[taskYangDiubah] == State.Ketemu)
                        {
                            Console.WriteLine("Tugas selesai.");
                            Bayar();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Trigger tidak valid.");
                    }

                } while (true);
            }

            private void Bayar()
            {
                // Placeholder method for further implementation
                Console.WriteLine("Membayar...");
            }
        }

    }
}