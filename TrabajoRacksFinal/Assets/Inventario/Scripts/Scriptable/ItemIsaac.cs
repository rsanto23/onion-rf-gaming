using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public  abstract class ItemIsaac: ScriptableObject, IItem
    {
        [Header("Common fields")]
        [SerializeField]
        protected string m_Id = "";
        public string Id { get => m_Id; set => m_Id = value; }
        [SerializeField]
        protected string m_Description = "";
        public string Description { get => m_Description; set => m_Description = value; }
        [SerializeField]
        protected Sprite m_Sprite = null;
        public Sprite Sprite { get => m_Sprite; set => m_Sprite = value; }

        public abstract bool UsedBy(GameObject go);
    }
