# unity-webgl-enter-bug
An example Unity project showcasing a potential bug present in WebGL builds when the enter key is pressed.

## Repro:

1) Run the project in the Unity editor. Notice that typing on the keyboard more or less updates the Text component as expected. The return key does nothing.
2) Build and Run for WebGL.
3) Notice that in the built application, the return key now literally types out the characters "Enter". This is not intended behavior.
