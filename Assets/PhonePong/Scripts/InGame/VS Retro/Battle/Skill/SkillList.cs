// System
using System;
using System.Collections;
using System.Collections.Generic;
using PhonePong.VSRetro.Battle.Skill;


// Unity
using UnityEngine;

public class SkillList
{
    public List<ISkill> skills { get; private set; }

    public SkillList(List<ISkill> skills)
    {
        this.skills = skills;
    }
}
