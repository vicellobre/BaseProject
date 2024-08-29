using NUnit.Framework;
using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayModeDebugTest
{
    [UnityTest]
    public IEnumerator CheckConditionWithDebugLog()
    {
        // Supongamos que tienes una funci�n que devuelve un valor booleano
        bool IsConditionMet() => true; // �Puedes cambiar esto seg�n tu l�gica!

        // Verifica si la condici�n est� cumplida
        bool conditionResult = IsConditionMet();

        // Muestra un mensaje en la consola con Debug.Log
        Debug.Log($"La condici�n es: {conditionResult}");

        // Espera un fotograma para que se aplique el Debug.Log
        yield return null;

        // Verifica si la condici�n es verdadera (puedes ajustar esto seg�n tus necesidades)
        Assert.IsTrue(conditionResult);
    }
}
