﻿using System;
using System.Collections.Generic;

namespace wECS.Core
{
    public abstract class ExecuteSystem<T1> : IExecuteSystem where T1 : IComponent
    {
        protected readonly List<GameEntity> Entities;

        protected ExecuteSystem()
        {
            Entities = GameMatcher.Get(new List<Type>
            {
                typeof(T1)
            }).All;
        }

        public abstract void Execute();
    }

    public abstract class ExecuteSystem<T1, T2> : IExecuteSystem where T1 : IComponent where T2 : IComponent
    {
        protected readonly List<GameEntity> Entities;

        protected ExecuteSystem()
        {
            Entities = GameMatcher.Get(new List<Type>
            {
                typeof(T1),
                typeof(T2)
            }).All;
        }

        public abstract void Execute();
    }

    public abstract class ExecuteSystem<T1, T2, T3> : IExecuteSystem
        where T1 : IComponent where T2 : IComponent where T3 : IComponent
    {
        protected readonly List<GameEntity> Entities;

        protected ExecuteSystem()
        {
            Entities = GameMatcher.Get(new List<Type>
            {
                typeof(T1),
                typeof(T2),
                typeof(T3)
            }).All;
        }

        public abstract void Execute();
    }

    public abstract class ExecuteSystem<T1, T2, T3, T4> : IExecuteSystem
        where T1 : IComponent where T2 : IComponent where T3 : IComponent where T4 : IComponent
    {
        protected readonly List<GameEntity> Entities;

        protected ExecuteSystem()
        {
            Entities = GameMatcher.Get(new List<Type>
            {
                typeof(T1),
                typeof(T2),
                typeof(T3),
                typeof(T4)
            }).All;
        }

        public abstract void Execute();
    }
}