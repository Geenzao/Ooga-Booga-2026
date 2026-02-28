using NUnit.Framework.Constraints;
using System;
using System.Numerics;
using TMPro;
using UnityEngine;
using System.Collections.Generic;


public class Ecriveur : MonoBehaviour
{
    [SerializeField] private TMP_Text sentencePrevious;
    [SerializeField] private TMP_Text sentenceActual;

    private string textPrevious = "";
    private string textActual = "";

    //Si l'utilisateur à écrit "je su", la variable vaut 5
    public int indexOfActualCharacter;
    public List<int> indexesOfErrorsInActualSentence;
    private List<int> indexesOfErrorsInPreviousSentence;
    private List<string> listOfSentences = new List<string>(new String[]{"Optimize headcount for maximum shareholder value",
    "Reduce labor costs to improve margins",
    "Lower the budget allocated to employee benefits",
    "Delay salary reviews due to financial constraints",
    "Outsource roles to cut operational expenses",
    "Freeze hiring to control overhead",
    "Implement unpaid overtime during peak periods",
    "Minimize training investment to protect short term profits",
    "Reallocate bonuses toward executive compensation",
    "Streamline teams through strategic downsizing",
    "Deprioritize employee well being initiatives",
    "Cap promotions to maintain structural efficiency",
    "Replace senior staff with lower cost junior resources",
    "Shift from full time contracts to temporary staffing",
    "Limit remote work to increase supervision",
    "Consolidate roles without adjusting compensation",
    "Reduce paid leave allowances",
    "Eliminate non essential perks",
    "Increase performance targets without raising salaries",
    "Postpone infrastructure upgrades to cut spending",
    "Centralize decision making to tighten control",
    "Suppress dissent to maintain alignment",
    "Encourage internal competition over collaboration",
    "Prioritize short term quarterly results over long term stability",
    "Standardize compensation regardless of workload variance",
    "Leverage workforce flexibility to avoid long term commitments",
    "Reassess employee value based solely on output metrics",
    "Implement strict cost control measures across all departments",
    "Shift healthcare costs to employees",
    "Delay reimbursements to preserve cash flow",
    "Mandatory off the clock email responses",
    "Install monitoring software to track productivity",
    "Encourage employees to sacrifice personal time for company goals",
    "Dismiss union organizing attempts as disloyal behavior",
    "Create culture of fear to discourage speaking up",
    "Normalize working through lunch breaks",
    "Use non compete clauses to limit career mobility",
    "Implement stack ranking to force terminations",
    "Threaten automation to suppress wage negotiations",
    "Replace benefits with empty recognition programs",
    "Mandate return to office to force voluntary resignations",
    "Gaslight employees about market rate compensation",
    "Use unlimited PTO to discourage actual vacation time",
    "Schedule important meetings during off hours",
    "Promote hustle culture over work life balance",
    "Treat employees as disposable resources",
    "Exploit passion for the mission to justify low pay",
    "Create arbitrary metrics to deny bonuses",
    "Normalize responding to Slack on weekends",
    "Use corporate jargon to obscure unethical decisions",
    "Mr Zober is ugly" });

    private void DrawRandomSentenceForActualSentence()
    {
        textActual = listOfSentences[UnityEngine.Random.Range(0, listOfSentences.Count)];
    }

    private string GenerateBalisedText(string sentence, List<int> indexesOfErrors, int indexOfLastTypedCharacter = 0)
    {
        if (indexOfLastTypedCharacter > sentence.Length)
        {
            Debug.LogError("La c est chelou mec. Va gronder Hugo");
        }
        string toReturn = "";
        int i = 0;
        while (i < indexOfLastTypedCharacter)
        {
            bool isError = false;
            foreach (int index in indexesOfErrors)
            {
                if (index == i)
                {
                    isError = true;
                    break;
                }
            }
            if (isError)
            {
                toReturn += "<color=red>";
                toReturn += sentence[i];
                toReturn += "</color>";
            }
            else
            {
                toReturn += "<color=green>";
                toReturn += sentence[i];
                toReturn += "</color>";
            }
            i = i + 1;
        }
        toReturn += "<color=black>";
        while (i < sentence.Length)
        {
            toReturn += sentence[i];
            i= i + 1;
        }
        toReturn += "</color>";
        return toReturn;
    }
    public void OnSentenceEnding()
    {
        indexOfActualCharacter = 0;
        textPrevious = textActual;
        indexesOfErrorsInPreviousSentence = indexesOfErrorsInActualSentence;
        indexesOfErrorsInActualSentence = new List<int>();
        sentencePrevious.text = GenerateBalisedText(textPrevious, indexesOfErrorsInPreviousSentence, textPrevious.Length);
        DrawRandomSentenceForActualSentence();
        sentenceActual.text = GenerateBalisedText(textActual, indexesOfErrorsInActualSentence);
    }

    void Start()
    {
        //Placement de premières phrases
        textPrevious = "";
        sentencePrevious.text = "";
        DrawRandomSentenceForActualSentence();
        sentenceActual.text = GenerateBalisedText(textActual,indexesOfErrorsInActualSentence);
    }


    void Update()
    {
        string buffer = "";
        if(Input.GetKeyDown(KeyCode.A))
        {
            buffer += "A";
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            buffer += "Z";
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            buffer += "E";
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            buffer += "R";
        }
        if(Input.GetKeyDown(KeyCode.T))
        {
            buffer += "T";
        }
        if(Input.GetKeyDown(KeyCode.Y))
        {
            buffer += "Y";
        }
        if(Input.GetKeyDown(KeyCode.U))
        {
            buffer += "U";
        }
        if(Input.GetKeyDown(KeyCode.I))
        {
            buffer += "I";
        }
        if(Input.GetKeyDown(KeyCode.O))
        {
            buffer += "O";
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            buffer += "P";
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            buffer += "Q";
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            buffer += "S";
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            buffer += "D";
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            buffer += "F";
        }
        if(Input.GetKeyDown(KeyCode.G))
        {
            buffer += "G";
        }
        if(Input.GetKeyDown(KeyCode.H))
        {
            buffer += "H";
        }
        if(Input.GetKeyDown(KeyCode.J))
        {
            buffer += "J";
        }
        if(Input.GetKeyDown(KeyCode.K))
        {
            buffer += "K";
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            buffer += "L";
        }
        if(Input.GetKeyDown(KeyCode.M))
        {
            buffer += "M";
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            buffer += "W";
        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            buffer += "X";
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            buffer += "C";
        }
        if(Input.GetKeyDown(KeyCode.V))
        {
            buffer += "V";
        }
        if(Input.GetKeyDown(KeyCode.B))
        {
            buffer += "B";
        }
        if(Input.GetKeyDown(KeyCode.N))
        {
            buffer += "N";
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            buffer += " ";
        }
        //Vérification des erreurs
        for (int j = 0; j < buffer.Length; j++)
        {
            if (buffer[j] == textActual[indexOfActualCharacter] || buffer[j] == char.ToLower(textActual[indexOfActualCharacter])|| buffer[j] == char.ToUpper(textActual[indexOfActualCharacter]))
            {
                //TODO:IncreaseXP
            }
            else
            {
                indexesOfErrorsInActualSentence.Add(indexOfActualCharacter);
                //TODO:LowerXP
            }
            indexOfActualCharacter++;
            if (indexOfActualCharacter >= textActual.Length)
            {
                OnSentenceEnding();
                //TODO:Jouer le son du patron content ou pas content
            }
        }
        sentenceActual.text = GenerateBalisedText(textActual, indexesOfErrorsInActualSentence, indexOfActualCharacter);
    }
}
