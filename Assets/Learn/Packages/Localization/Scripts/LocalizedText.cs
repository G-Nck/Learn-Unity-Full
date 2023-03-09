using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Localization;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Localization.SmartFormat.PersistentVariables;
using System;

namespace Learn.Localization
{

    [RequireComponent(typeof(TMP_Text))]

    public class LocalizedText : MonoBehaviour
    {
        TMP_Text text;
        LocalizedString localizedString = new LocalizedString();

        public new string name = "ÁÖÁø¿ì";
        private void Awake()
        {
            text = GetComponent<TMP_Text>();
        }

        private void OnEnable()
        {
            localizedString.Arguments = new[] { name };
            localizedString.StringChanged += UpdateString;
        }

        private void OnDisable()
        {
            localizedString.StringChanged -= UpdateString;

        }

        private void Start()
        {



            GetLocalizedStringAsync("Sample", "SMART_SAMPLE", onComplete : SetText);
        }

        private void Update()
        {
            localizedString.Arguments = new[] { name };

            localizedString.RefreshString();
        }

        public void UpdateString(string s)
        {
            text.text = s;
        }

        public void GetLocalizedStringAsync(string tableName, string keyName, Action<AsyncOperationHandle<string>> onComplete)
        {
            localizedString.SetReference(tableName, keyName);
            //var stringOperation = localizedString.GetLocalizedStringAsync(new Dictionary<string, string>() { { "name", "MY_NAME" } });
            var stringOperation = localizedString.GetLocalizedStringAsync();
            stringOperation.Completed += onComplete;

        }

        public void meow()
        {
            
        }

        void SetSmart(AsyncOperationHandle<string> asyncOperationHandle)
        {
        }

        void SetText(AsyncOperationHandle<string> asyncOperationHandle)
        {
            text.text = asyncOperationHandle.Result;

        }
    }
}
