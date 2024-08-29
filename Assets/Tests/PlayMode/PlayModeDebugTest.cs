using NUnit.Framework;
using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayModeDebugTest
{
    [UnityTest]
    public IEnumerator CheckConditionWithDebugLog()
    {
        // Supongamos que tienes una función que devuelve un valor booleano
        bool IsConditionMet() => true; // ¡Puedes cambiar esto según tu lógica!

        // Verifica si la condición está cumplida
        bool conditionResult = IsConditionMet();

        // Muestra un mensaje en la consola con Debug.Log
        Debug.Log($"La condición es: {conditionResult}");

        // Espera un fotograma para que se aplique el Debug.Log
        yield return null;

        // Verifica si la condición es verdadera (puedes ajustar esto según tus necesidades)
        Assert.IsTrue(conditionResult);
    }
}
