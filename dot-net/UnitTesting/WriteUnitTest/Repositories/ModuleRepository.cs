﻿using System.Collections.Generic;
using System.Linq;
using WriteUnitTest.Entities;

namespace WriteUnitTest.Repositories
{
    //attaching repository to interface to allow for mocking/dependency injection
    public class ModuleRepository : IModuleRepository
    {
        private readonly List<Module> moduleList;

        public ModuleRepository()
        {
            moduleList = new List<Module>
            {
                new Module
                {
                    ModuleId = 873,
                    MinimumPassingGrade = 80,
                    Lessons = new List<Lesson>
                    {
                        new Lesson
                        {
                            LessonId = 12,
                            Grade = 63.7d,
                            IsPassed = false
                        },
                        new Lesson
                        {
                            LessonId = 86,
                            Grade = 88.2d,
                            IsPassed = true
                        }
                    }
                }
            };
        }

        public Module GetModule(int lessonId)
        {
            return moduleList.FirstOrDefault(x => x.Lessons.Any(y => y.LessonId == lessonId));
        }
    }
}