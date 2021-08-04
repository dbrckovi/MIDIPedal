# MIDIPedal
Universal MIDI pedal controlled by arduino

This is still in the early 'idea' stage.
Arduino is connected to PC with standard USB cable.
It reads the input from several (foot) buttons and a foot pedal.
Using this data, constructs MIDI messages and sends them as a series of bytes to the standard serial interface.

PC runs a MIDI siulator program (either downloaded, or written here) which reads the serial data received by arduino and converts them to MIDI commands.

MIDI commands are received by DAW software and used to control VST plugins.

Readme will be expanded