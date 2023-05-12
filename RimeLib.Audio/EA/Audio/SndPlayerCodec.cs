
namespace RimeLib.Audio.EA.Audio;

public enum SndPlayerCodec
{
	//XaSeekable0 = 0,
	//EaLayer30 = 1,
	
	Pcm16Big = 2,		// "P6B0"
	EaXma = 3,			// "EXm0" Not compiled into game
	XaSeekable1 = 4,	// "Xas1"
	EaLayer31 = 5,		// "EL13" ealayer is based of mpeg-3
	EaLayer32Pcm = 6,	// "L32P" ealayer is based of mpeg-3
	EaLayer32Spike = 7,	// "L32S" ealayer is based of mpeg-3
	//GcAdpcm = 8
	EaSpeex = 9,		// "Eps0"
	
	//Atrac9 = 10,
	//EaMp3 = 11,			// "EM30"
	
}