﻿namespace Domain.Entity
{
    public class Proposal
    {
        public int Id { get; set; }
        public string Descripton { get; set; }
        public int Price { get; set; }
        public int ExecutorId { get; set; }
        public Executor Executor { get; set; }
    }
}