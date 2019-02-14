﻿using System;
using System.Collections.Generic;
using com.ootii.Actors.AnimationControllers;
using com.ootii.Base;
using com.ootii.Data.Serializers;
using com.ootii.Helpers;
using UnityEditor;
using UnityEngine;

namespace com.ootii.Setup
{
    /// <summary>
    /// Base class for a Setup Module.
    /// </summary>
    public abstract class SetupModule : BaseObject, ISetupModule, ISerializableObject
    {
        /// <summary>
        /// Indicates that the Setup Module has valid settings and can be run
        /// </summary>
        public virtual bool IsValid { get { return true; } }

        /// <summary>
        /// The priority of the module relative to others (when determining the order
        /// in which modules are run during character setup). 
        /// </summary>
        /// <remarks>CURRENTLY UNUSED</remarks>
        public float _Priority = 0;
        public virtual float Priority
        {
            get { return _Priority; }
            set { _Priority = value; }
        }
        /// <summary>
        /// Modules can be grouped together by a category ID.
        /// </summary>
        /// <remarks>CURRENTLY UNUSED</remarks>
        public int _Category = 0;
        public int Category
        {
            get { return _Category; }
            set { _Category = value; }
        }

        /// <summary>
        /// A SetupModule can have dependencies on other Modules
        /// </summary>
        /// <remarks>CURRENTLY UNUSED</remarks>
        public List<Type> RequiredModules
        {
            get
            {
                if (mRequiredModules == null && !mCheckedRequirements)
                {
                    mRequiredModules = ModuleRequiresAttribute.GetRequiredTypes(this.GetType());
                    mCheckedRequirements = true;
                }
                return mRequiredModules;
            }
        }
        protected List<Type> mRequiredModules = null;
        private bool mCheckedRequirements = false;

        // The Module Inspector's foldout state, if used
        protected bool mFoldoutState = true;

        // Character references
        protected MotionController mMotionController;
        protected GameObject mCharacterGO;
        protected bool mIsPlayer = true;
        
        /// <summary>
        /// Serializes the object into a string
        /// </summary>
        /// <returns>JSON string representing the object</returns>
        public virtual string Serialize()
        {
            return JSONSerializer.Serialize(this, false);
        }

        /// <summary>
        /// Deserialize the object from a string
        /// </summary>
        /// <param name="rDefinition">JSON string</param>
        public virtual void Deserialize(string rDefinition)
        {
            object lThis = this;
            JSONSerializer.DeserializeInto(rDefinition, ref lThis);
        }

        protected SetupModule()
        {
            // Try to get the display name of the module from the ModuleName attribute
            _Name = ModuleNameAttribute.GetName(this.GetType());
        }
       
        /// <summary>
        /// Checks if the Module uses the specified component.
        /// </summary>
        /// <param name="rType"></param>
        /// <returns></returns>
        public virtual bool UsesComponent(Type rType)
        {
            var lAttributes = ModuleUsesComponentAttribute.GetComponentTypes(this.GetType());
            return lAttributes.Contains(rType);            
        }

        /// <summary>
        /// Initialize the Module
        /// </summary>
        /// <param name="rUseDefaults"></param>
        public virtual void Initialize(bool rUseDefaults = false)
        {

        }

        /// <summary>
        /// Begin the setup process by setting the reference to the created Motion Controller component
        /// and flagging if we're setting up a player or NPC
        /// </summary>
        /// <param name="rMotionController"></param>
        /// <param name="rIsPlayer"></param>
        public virtual void BeginSetup(MotionController rMotionController, bool rIsPlayer = true)
        {
            mMotionController = rMotionController;
            mCharacterGO = rMotionController.gameObject;          
            mIsPlayer = rIsPlayer;
        }

        /// <summary>
        /// Draw the Inspector for the Module
        /// </summary>
        /// <param name="rTarget"></param>
        /// <returns></returns>
        public virtual bool OnInspectorGUI(UnityEngine.Object rTarget)
        {
            return false;
        }

        /// <summary>
        /// Draws a sub-section within the Module's Inspector
        /// </summary>
        /// <param name="rTitle"></param>
        /// <param name="rDrawContentsAction"></param>
        /// <param name="rDisabled"></param>
        protected virtual void DrawModuleSection(string rTitle, Action rDrawContentsAction, bool rDisabled = false)
        {
            EditorGUI.BeginDisabledGroup(rDisabled);
            try
            {
                GUILayout.BeginVertical(EditorHelper.Box);
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(4f);
                EditorGUILayout.LabelField(rTitle, EditorStyles.boldLabel);
                EditorGUILayout.EndHorizontal();

                rDrawContentsAction();
            }
            finally
            {
                GUILayout.EndVertical();
            }
            EditorGUI.EndDisabledGroup();
            
            EditorGUILayout.Separator();
        } 
    }
}

