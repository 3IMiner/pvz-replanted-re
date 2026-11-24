# System.Boolean HasHeadAnimation()

- 类：`Plant`
- 汇编行数：39

## 反汇编

```asm

Disassembly:
	cmp dword ptr [rcx+70h],0
	je short 00000001806B1EBCh
	cmp dword ptr [rcx+70h],7
	je short 00000001806B1EBCh
	cmp dword ptr [rcx+70h],28h
	je short 00000001806B1EBCh
	cmp dword ptr [rcx+70h],34h
	je short 00000001806B1EBCh
	cmp dword ptr [rcx+70h],5
	je short 00000001806B1EBCh
	cmp dword ptr [rcx+70h],1Ch
	je short 00000001806B1EBCh
	cmp dword ptr [rcx+70h],12h
	sete al
	ret
	mov al,1
	ret

ISIL:
	001 Compare [rcx+112], 0
	002 JumpIfEqual {16}
	003 Compare [rcx+112], 7
	004 JumpIfEqual {16}
	005 Compare [rcx+112], 40
	006 JumpIfEqual {16}
	007 Compare [rcx+112], 52
	008 JumpIfEqual {16}
	009 Compare [rcx+112], 5
	010 JumpIfEqual {16}
	011 Compare [rcx+112], 28
	012 JumpIfEqual {16}
	013 Compare [rcx+112], 18
	014 NotImplemented "sete al"
	015 Return rax
	016 Move rax, 1
	017 Return rax
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
