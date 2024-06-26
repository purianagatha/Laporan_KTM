﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace GUI_Laporan_KTM
{
    public class StateKTM
    {
        public enum PengerjaanState
        {
            BelumDiProses,
            SudahDiProses,
            Bermasalah,
            Selesai
        }

        public enum Trigger
        {
            Cari,
            Bermasalah,
            Proses,

        }

        class Transition
        {
            public PengerjaanState StateAwal;
            public PengerjaanState StateAkhir;
            public Trigger Trigger;

            public Transition(PengerjaanState stateAwal, PengerjaanState stateAkhir, Trigger trigger)
            {
                StateAwal = stateAwal;
                StateAkhir = stateAkhir;
                Trigger = trigger;
            }
        }

        Transition[] transisi =
        {
            new Transition(PengerjaanState.BelumDiProses, PengerjaanState.SudahDiProses, Trigger.Cari),
            new Transition(PengerjaanState.SudahDiProses, PengerjaanState.Bermasalah, Trigger.Bermasalah),

            new Transition(PengerjaanState.Bermasalah, PengerjaanState.SudahDiProses, Trigger.Proses),
            new Transition(PengerjaanState.SudahDiProses, PengerjaanState.Selesai, Trigger.Proses),

        };

        public PengerjaanState currentState = PengerjaanState.BelumDiProses;
        public Dictionary<string, PengerjaanState> tasks = new Dictionary<string, PengerjaanState>(); // Dictionary to store tasks with their states

        public PengerjaanState GetNextState(PengerjaanState stateAwal, Trigger trigger)
        {
            foreach (Transition perubahan in transisi)
            {
                if (stateAwal == perubahan.StateAwal && trigger == perubahan.Trigger)
                {
                    return perubahan.StateAkhir;
                }
            }
            throw new InvalidOperationException("Invalid state transition.");
        }

        public void ActivateTrigger(Trigger trigger)
        {
            currentState = GetNextState(currentState, trigger);
            Console.WriteLine("State NIM Anda adalah: " + currentState);
        }



        public string ChangeTaskState(string nim, PengerjaanState newState)
        {
            if (tasks.ContainsKey(nim))
            {
                tasks[nim] = newState;
                return newState.ToString();
            }
            else
            {
                return "terjadi kesalahan";
            }
        }

    }
}