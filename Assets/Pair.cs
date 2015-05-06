using UnityEngine;
using System.Collections;

public class Pair<T1, T2>{

	private readonly T1 first;

	private readonly T2 second;

	public T1 getFirst {
		get { return first; }
	}

	public T2 getSecond {
		get { return second; }
	}

	public Pair (T1 firstItem, T2 secondItem) {
		this.first = firstItem;
		this.second = secondItem;
	}
}
