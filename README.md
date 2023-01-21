# ~ Unity ~
## Animation
* __Animator Component__ - assigns animations to GameObjects through an Animator Controller.
* __Animator Controller__ - arrangement of animations and transitions (state machine).
* __Animation__ - specific pieces of motion.
* __Sprite Renderer__ - displays the 2D sprite on screen.

#### Steps to set up character's idle:
1. import spritesheet and slice;
2. add sprite renderer to Player;
3. create idle animation clip;
4. create Character Animation Controller;
5. add idle animation to Animator Controller;
6. add Animator to Player;
7. assign Character Animator Controller to Player.

## Prefabs
* Prefabs are game objects which we have turned into reusable templates.
* The original template is called the __Prefab__ and the copies we add into our scene are called __Instances__.
* Turning a game object into a prefab means we can easily load into any scene in our game.
## Flippin' Logic
* If the player is pushing right, the velocity will be positive. If left, then negative.
* If movement right, we should face right. If left, face left.
* We can change the facing direction (right or left) by changing the localscale using +ve or -ve value.
* Only change facing direction if moving, so weird things don't happen when velocity is zero.
## Layers
* Layers are useful if we have the same functionality across multiple GameObjects. E.g. ignored by camera, not clickable, collision check.
* To stop jumping anytime we use `Collider2D.IsTouchingLayers()`.

#### Collider2D.IsTouchingLayers()
* Checks whether this collider is touching any colliders on the specified layerMask or not.
* Returns __bool__.

#### LayerMask.GetMask()
* Given a set of layer names as defined by either a Builtin or a User Layer in the Tags and Layers manager, returns the equivalent layer mask for all of them.
* Returns __int__ (the layer mask created from the layerNames).

***
# ~ C# ~
## Mathf.Sign
* `Mathf.Sign(float f);`
* Returns the sign of f.
* Return value is 1 when f is positive or zero, -1 when f is negative.

## Mathf.Abs
* `Mathf.Abs(float f);`
* Returns the absolute value of f.

## Mathf.Epsilon
* A tiny floating point value (Read Only).
* The smallest value that a float can have different from zero.
* With the following rules:
    * anyValue + Epsilon = anyValue
    * anyValue - Epsilon = anyValue
    * 0 + Epsilon = Epsilon
    * 0 - Epsilon = -Epsilon
* A value Between any number and Epsilon will result in an arbitrary number due to truncating errors.

## Coroutines
* Coroutines are another way for us to create a delay in our game.
* The core concept to understand is that we start a process (ie. Start Coroutine) and then go off and do other things (ie. Yield) until our condition (eg. we've waited 2 seconds) is met.
#### Coroutines Code
We call:
`StartCoroutine(NameOfMethod());`

Our method:
```
IEnumerator NameOfMethod()
{
    yield return new WaitForSecondsRealtime(time);

    // Anything you want to do after waiting
}
```