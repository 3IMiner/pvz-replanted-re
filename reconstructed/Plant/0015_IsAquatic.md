# System.Boolean IsAquatic(Reloaded.Gameplay.SeedType theSeedType)

- 类：`Plant`
- 汇编行数：25

## 反汇编

```asm

Disassembly:
	cmp ecx,18h
	ja short 00000001806B21D2h
	mov eax,1090000h
	bt eax,ecx
	jae short 00000001806B21D2h
	mov al,1
	ret
	cmp ecx,2Bh
	sete al
	ret

ISIL:
	001 Compare rcx, 24
	002 JumpIfGreater {8}
	003 Move rax, 0x1090000
	004 NotImplemented "bt eax,ecx"
	005 JumpIfGreaterOrEqual {8}
	006 Move rax, 1
	007 Return rax
	008 Compare rcx, 43
	009 NotImplemented "sete al"
	010 Return rax
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
