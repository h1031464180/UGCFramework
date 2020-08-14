﻿using System.Collections;
using System.Collections.Generic;
using UGCF.UnityExtend;
using UGCF.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UGCF.Manager
{
    public class TipItem : MonoBehaviour
    {
        public Text describeTxt;
        public GameObject background, btnSure, btnCancel, btnClose;
        public TipType tipType;
        public float waitTime;
        UnityAction sureAction, cancelAction;
        Coroutine delayClose;

        void Start()
        {
            RectTransform tf = GetComponent<RectTransform>();
            tf.anchoredPosition = Vector3.zero;
            tf.sizeDelta = Vector3.zero;
            tf.localScale = Vector3.one;

            if (tipType == TipType.SimpleTip && background)
                UGUIEventListener.Get(background).onClick = delegate { Close(true); };
            if (btnClose)
                UGUIEventListener.Get(btnClose).onClick = delegate { Close(true); };
            if (btnSure)
                UGUIEventListener.Get(btnSure).onClick = delegate { gameObject.SetActive(false); sureAction?.Invoke(); };
            if (btnCancel)
                UGUIEventListener.Get(btnCancel).onClick = delegate { gameObject.SetActive(false); cancelAction?.Invoke(); };
        }

        public void Init(string _describe, float _waitTime = 0, UnityAction _sureAction = null, UnityAction _cancelAction = null)
        {
            describeTxt.text = _describe;
            sureAction = _sureAction;
            cancelAction = _cancelAction;
            gameObject.SetActive(true);
            if (_waitTime > 0)
                waitTime = _waitTime;
            if (waitTime > 0)
            {
                if (delayClose != null)
                    TipManager.Instance.StopCoroutine(delayClose);
                delayClose = TipManager.Instance.StartCoroutine(DelayClose());
            }
        }

        IEnumerator DelayClose()
        {
            yield return WaitForUtils.WaitForSecondsRealtime(waitTime);
            Close(true);
        }

        public void Close(bool isImplementCallBack = false)
        {
            if (this && gameObject.activeSelf)
            {
                switch (tipType)
                {
                    case TipType.SimpleTip:
                    case TipType.AlertTip:
                        if (isImplementCallBack && sureAction != null)
                            sureAction();
                        break;
                    case TipType.ChooseTip:
                        if (isImplementCallBack && cancelAction != null)
                            cancelAction();
                        break;
                }
                gameObject.SetActive(false);
            }
        }
    }
}