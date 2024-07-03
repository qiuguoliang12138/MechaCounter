﻿using System.Collections.Generic;

namespace Project.Scripts
{
    /// <summary>
    /// 技能类型
    /// </summary>
    public enum ESkillType
    {
        /// <summary>
        /// 枪械伤害技能
        /// </summary>
        Gun = 1,
        /// <summary>
        /// 炮伤害技能
        /// </summary>
        Cannon = 1 << 1,
        /// <summary>
        /// 拳伤害技能
        /// </summary>
        Boxing = 1 << 2,
        /// <summary>
        /// 刀剑伤害技能
        /// </summary>
        Sword = 1 << 3,
        /// <summary>
        /// 伤害技能
        /// </summary>
        DamageSkill = Gun | Cannon | Boxing | Sword,
        /// <summary>
        /// 速度技能
        /// </summary>
        Speed = 1 << 4,
        /// <summary>
        /// Buff技能
        /// </summary>
        Buff = 1 << 5
    }

    public interface ISkill
    {
        /// <summary>
        /// 技能类型
        /// </summary>
        public ESkillType SkillType { get; }
        
        /// <summary>
        /// 技能等级
        /// </summary>
        public int Level { get; }
        
        /// <summary>
        /// 层数
        /// </summary>
        public int LayerLevel { get; }
        
        /// <summary>
        /// 技能威力
        /// </summary>
        public int AbilityDfs { get; }
        
        /// <summary>
        /// 消耗魔力
        /// </summary>
        public int CostMp { get; }
        
        /// <summary>
        /// 能源核心适配等级
        /// </summary>
        public HashSet<int> EnergyCoreAdaptLevel { get; }
        
        /// <summary>
        /// 携带招式
        /// </summary>
        public HashSet<ITrack> Tracks { get; }

        #region -----上阵属性-----

        /// <summary>
        /// 气血
        /// </summary>
        /// <returns></returns>
        public int Hp { get; }
        
        /// <summary>
        /// 攻击
        /// </summary>
        /// <returns></returns>
        public int Atk { get; }
        
        /// <summary>
        /// 防御
        /// </summary>
        public int Def { get; }

        #endregion
    }
    
    


    public class Skill
    {
        
    }

        
}