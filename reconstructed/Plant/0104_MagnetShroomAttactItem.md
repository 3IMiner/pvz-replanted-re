# System.Void MagnetShroomAttactItem(Reloaded.Gameplay.Zombie theZombie)

- 类：`Plant`
- 汇编行数：879

## 反汇编

```asm

Disassembly:
	mov [rsp+18h],rbx
	mov [rsp+20h],rsi
	push rdi
	sub rsp,80h
	cmp byte ptr [184EEB665h],0
	mov rbx,rdx
	mov rdi,rcx
	jne short 00000001806B29D0h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C984C0h]
	call 00000001804FEB70h
	lea rcx,[184C40BB0h]
	call 00000001804FEB70h
	lea rcx,[184C98310h]
	call 00000001804FEB70h
	lea rcx,[184C3A350h]
	call 00000001804FEB70h
	lea rcx,[184C93578h]
	call 00000001804FEB70h
	lea rcx,[184C3B660h]
	call 00000001804FEB70h
	lea rcx,[184C3C2C8h]
	call 00000001804FEB70h
	lea rcx,[184C95228h]
	call 00000001804FEB70h
	mov byte ptr [184EEB665h],1
	cmp byte ptr [184EEB658h],0
	mov dword ptr [rdi+88h],1Ah
	mov dword ptr [rdi+0A0h],5DCh
	mov rsi,[184C984C0h]
	jne short 00000001806B2A13h
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	mov [rsp+98h],rbp
	movaps [rsp+70h],xmm6
	movaps [rsp+60h],xmm7
	movaps [rsp+50h],xmm8
	test rsi,rsi
	je near ptr 00000001806B3180h
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rsi
	call 0000000182A24E50h
	mov rcx,[rdi+140h]
	mov rsi,rax
	test rcx,rcx
	je near ptr 00000001806B3180h
	movss xmm8,dword ptr [183C33DBCh]
	xor r9d,r9d
	movaps xmm1,xmm8
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rdi+140h]
	test rcx,rcx
	je near ptr 00000001806B3180h
	movss xmm3,dword ptr [183C33DB4h]
	xor ebp,ebp
	mov [rsp+28h],rbp
	xor r8d,r8d
	mov rdx,rsi
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov r8,[rdi+10h]
	test r8,r8
	je near ptr 00000001806B3180h
	mov r8,[r8+58h]
	test r8,r8
	je near ptr 00000001806B3180h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,2Ah
	call 0000000180002040h
	xor edx,edx
	mov rcx,rdi
	call 00000001806B13B0h
	mov rdi,rax
	test rbx,rbx
	je near ptr 00000001806B3180h
	cmp dword ptr [rbx+11Ch],2
	je near ptr 00000001806B307Eh
	cmp dword ptr [rbx+11Ch],3
	je near ptr 00000001806B2F7Ah
	cmp dword ptr [rbx+130h],1
	je near ptr 00000001806B2E99h
	cmp dword ptr [rbx+130h],5
	je near ptr 00000001806B2E99h
	cmp dword ptr [rbx+130h],3
	je near ptr 00000001806B2DEFh
	cmp dword ptr [rbx+70h],12h
	je near ptr 00000001806B2CE6h
	cmp dword ptr [rbx+74h],0Fh
	je near ptr 00000001806B2C0Ah
	cmp dword ptr [rbx+70h],11h
	jne near ptr 00000001806B2DC2h
	xor edx,edx
	mov rcx,rbx
	call 00000001806EC340h
	mov rdx,[184C3A350h]
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806F2BC0h
	mov [rsp+90h],rax
	test rdi,rdi
	je near ptr 00000001806B3180h
	movss xmm0,dword ptr [rsp+90h]
	xorps xmm1,xmm1
	subss xmm0,xmm1
	movss dword ptr [rdi+10h],xmm0
	movss xmm0,dword ptr [rsp+94h]
	subss xmm0,xmm1
	movss dword ptr [rdi+14h],xmm0
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],ebp
	jne short 00000001806B2BB8h
	call 00000001804FEEB0h
	movss xmm7,dword ptr [183C33DACh]
	xor r8d,r8d
	movss xmm6,dword ptr [183C33F38h]
	movaps xmm1,xmm7
	movaps xmm0,xmm6
	call 00000001806CBD40h
	addss xmm0,dword ptr [183C33E28h]
	xor r8d,r8d
	movaps xmm1,xmm7
	movss dword ptr [rdi+18h],xmm0
	movaps xmm0,xmm6
	call 00000001806CBD40h
	addss xmm0,dword ptr [183C33DB8h]
	mov dword ptr [rdi+20h],15h
	movss dword ptr [rdi+1Ch],xmm0
	jmp near ptr 00000001806B2DC2h
	xor edx,edx
	mov rcx,rbx
	call 00000001806F7DD0h
	xor edx,edx
	mov rcx,rbx
	call 00000001806F4B50h
	mov [rbx+74h],ebp
	xor r9d,r9d
	mov rdx,[184C3B660h]
	mov r8d,0FFFFFFFFh
	mov rcx,rbx
	call 00000001806F5AC0h
	mov rdx,[184C3B660h]
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806F2BC0h
	mov [rsp+90h],rax
	test rdi,rdi
	je near ptr 00000001806B3180h
	movss xmm0,dword ptr [rsp+90h]
	xorps xmm1,xmm1
	subss xmm0,xmm1
	movss dword ptr [rdi+10h],xmm0
	movss xmm0,dword ptr [rsp+94h]
	subss xmm0,xmm1
	movss dword ptr [rdi+14h],xmm0
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],ebp
	jne short 00000001806B2C97h
	call 00000001804FEEB0h
	movss xmm7,dword ptr [183C33DACh]
	xor r8d,r8d
	movss xmm6,dword ptr [183C33F38h]
	movaps xmm1,xmm7
	movaps xmm0,xmm6
	call 00000001806CBD40h
	addss xmm0,xmm8
	xor r8d,r8d
	movaps xmm1,xmm7
	movss dword ptr [rdi+18h],xmm0
	movaps xmm0,xmm6
	call 00000001806CBD40h
	addss xmm0,dword ptr [183C33DB8h]
	mov dword ptr [rdi+20h],0Dh
	movss dword ptr [rdi+1Ch],xmm0
	jmp near ptr 00000001806B2DC2h
	xor r8d,r8d
	mov edx,10h
	mov rcx,rbx
	call 00000001806F56E0h
	xor r8d,r8d
	lea rcx,[rsp+30h]
	mov rdx,rbx
	call 00000001806F2170h
	mov rdx,[184C3C2C8h]
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806F2BC0h
	mov [rsp+90h],rax
	test rdi,rdi
	je near ptr 00000001806B3180h
	movss xmm0,dword ptr [rsp+90h]
	movss xmm1,dword ptr [rsp+94h]
	addss xmm0,dword ptr [183C33DC4h]
	addss xmm1,dword ptr [183C33FF0h]
	movss dword ptr [rdi+10h],xmm0
	movss dword ptr [rdi+14h],xmm1
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],ebp
	jne short 00000001806B2D69h
	call 00000001804FEEB0h
	movss xmm7,dword ptr [183C33DACh]
	xor r8d,r8d
	movss xmm6,dword ptr [183C33F38h]
	movaps xmm1,xmm7
	movaps xmm0,xmm6
	call 00000001806CBD40h
	addss xmm0,dword ptr [183C33FD8h]
	xor r8d,r8d
	movaps xmm1,xmm7
	movss dword ptr [rdi+18h],xmm0
	movaps xmm0,xmm6
	call 00000001806CBD40h
	addss xmm0,xmm7
	mov eax,0Ah
	mov ecx,0Ch
	movss dword ptr [rdi+1Ch],xmm0
	cmp [rbx+113h],bpl
	cmove eax,ecx
	mov [rdi+20h],eax
	movaps xmm8,[rsp+50h]
	lea r11,[rsp+80h]
	mov rbx,[r11+20h]
	mov rsi,[r11+28h]
	movaps xmm7,[rsp+60h]
	movaps xmm6,[rsp+70h]
	mov rbp,[rsp+98h]
	mov rsp,r11
	pop rdi
	ret
	xor edx,edx
	mov rcx,rbx
	call 00000001806F2B20h
	xor edx,edx
	mov rcx,rbx
	mov esi,eax
	call 00000001806EBB50h
	test rdi,rdi
	je near ptr 00000001806B3180h
	movss xmm1,dword ptr [rbx+78h]
	xorps xmm0,xmm0
	addss xmm1,dword ptr [183C33FC0h]
	movss dword ptr [rdi+10h],xmm1
	subss xmm1,xmm0
	movss xmm2,dword ptr [rbx+7Ch]
	addss xmm2,xmm8
	movss dword ptr [rdi+10h],xmm1
	subss xmm2,xmm0
	movss dword ptr [rdi+14h],xmm2
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],ebp
	jne short 00000001806B2E53h
	call 00000001804FEEB0h
	movss xmm7,dword ptr [183C33DACh]
	xor r8d,r8d
	movss xmm6,dword ptr [183C33F38h]
	movaps xmm1,xmm7
	movaps xmm0,xmm6
	call 00000001806CBD40h
	addss xmm0,dword ptr [183C33C60h]
	xor r8d,r8d
	movaps xmm1,xmm7
	movss dword ptr [rdi+18h],xmm0
	movaps xmm0,xmm6
	call 00000001806CBD40h
	movss dword ptr [rdi+1Ch],xmm0
	lea eax,[rsi+0Eh]
	jmp near ptr 00000001806B2DBFh
	xor edx,edx
	mov rcx,rbx
	call 00000001806F2B20h
	xor edx,edx
	mov rcx,rbx
	mov esi,eax
	call 00000001806EBB50h
	mov [rbx+74h],ebp
	cmp [rbx+0A5h],bpl
	jne short 00000001806B2EC8h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rbx
	call 00000001806F7970h
	mov rdx,[184C98310h]
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806F2BC0h
	mov [rsp+90h],rax
	test rdi,rdi
	je near ptr 00000001806B3180h
	movss xmm0,dword ptr [rsp+90h]
	xorps xmm1,xmm1
	subss xmm0,xmm1
	movss dword ptr [rdi+10h],xmm0
	movss xmm0,dword ptr [rsp+94h]
	subss xmm0,xmm1
	movss dword ptr [rdi+14h],xmm0
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],ebp
	jne short 00000001806B2F26h
	call 00000001804FEEB0h
	movss xmm7,dword ptr [183C33DACh]
	xor r8d,r8d
	movss xmm6,dword ptr [183C33F38h]
	movaps xmm1,xmm7
	movaps xmm0,xmm6
	call 00000001806CBD40h
	addss xmm0,dword ptr [183C33C60h]
	xor r8d,r8d
	movaps xmm1,xmm7
	movss dword ptr [rdi+18h],xmm0
	movaps xmm0,xmm6
	call 00000001806CBD40h
	movss dword ptr [rdi+1Ch],xmm0
	cmp dword ptr [rbx+70h],6
	je short 00000001806B2F72h
	lea eax,[rsi+16h]
	jmp near ptr 00000001806B2DBFh
	lea eax,[rsi+7]
	jmp near ptr 00000001806B2DBFh
	xor edx,edx
	mov rcx,rbx
	call 00000001806F2980h
	mov [rbx+128h],ebp
	xor r8d,r8d
	mov [rbx+11Ch],ebp
	mov rcx,rbx
	mov rdx,[184C40BB0h]
	mov esi,eax
	call 00000001806F2BC0h
	mov [rsp+90h],rax
	test rdi,rdi
	je near ptr 00000001806B3180h
	movss xmm0,dword ptr [rsp+90h]
	xor r9d,r9d
	movss xmm1,dword ptr [rsp+94h]
	mov r8d,0FFFFFFFFh
	movss dword ptr [rdi+10h],xmm0
	mov rcx,rbx
	movss dword ptr [rdi+14h],xmm1
	mov rdx,[184C40BB0h]
	call 00000001806F5A90h
	mov rdx,[184C95228h]
	xor r9d,r9d
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806F5A90h
	movss xmm0,dword ptr [rbx+78h]
	addss xmm0,dword ptr [183C33FD0h]
	movss dword ptr [rdi+10h],xmm0
	movss xmm1,dword ptr [rbx+7Ch]
	subss xmm1,dword ptr [183C33C68h]
	movss dword ptr [rdi+14h],xmm1
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],ebp
	jne short 00000001806B3036h
	call 00000001804FEEB0h
	movss xmm7,dword ptr [183C33DACh]
	xor r8d,r8d
	movss xmm6,dword ptr [183C33F38h]
	movaps xmm1,xmm7
	movaps xmm0,xmm6
	call 00000001806CBD40h
	addss xmm0,xmm8
	xor r8d,r8d
	movaps xmm1,xmm7
	movss dword ptr [rdi+18h],xmm0
	movaps xmm0,xmm6
	call 00000001806CBD40h
	addss xmm0,xmm8
	lea eax,[rsi+4]
	movss dword ptr [rdi+1Ch],xmm0
	jmp near ptr 00000001806B2DBFh
	xor edx,edx
	mov rcx,rbx
	call 00000001806F2980h
	mov [rbx+128h],ebp
	xor r8d,r8d
	mov [rbx+11Ch],ebp
	mov rcx,rbx
	mov rdx,[184C93578h]
	mov esi,eax
	call 00000001806F2BC0h
	mov [rsp+90h],rax
	test rdi,rdi
	je near ptr 00000001806B3180h
	movss xmm0,dword ptr [rsp+90h]
	xor r9d,r9d
	movss xmm1,dword ptr [rsp+94h]
	mov r8d,0FFFFFFFFh
	movss dword ptr [rdi+10h],xmm0
	mov rcx,rbx
	movss dword ptr [rdi+14h],xmm1
	mov rdx,[184C93578h]
	call 00000001806F5A90h
	mov rdx,[184C95228h]
	xor r9d,r9d
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806F5A90h
	movss xmm0,dword ptr [rdi+10h]
	xorps xmm1,xmm1
	subss xmm0,xmm1
	movss dword ptr [rdi+10h],xmm0
	movss xmm0,dword ptr [rdi+14h]
	subss xmm0,xmm1
	movss dword ptr [rdi+14h],xmm0
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],ebp
	jne short 00000001806B3135h
	call 00000001804FEEB0h
	movss xmm7,dword ptr [183C33DACh]
	xor r8d,r8d
	movss xmm6,dword ptr [183C33F38h]
	movaps xmm1,xmm7
	movaps xmm0,xmm6
	call 00000001806CBD40h
	addss xmm0,dword ptr [183C33DC0h]
	xor r8d,r8d
	movaps xmm1,xmm7
	movss dword ptr [rdi+18h],xmm0
	movaps xmm0,xmm6
	call 00000001806CBD40h
	addss xmm0,xmm8
	lea eax,[rsi+1]
	movss dword ptr [rdi+1Ch],xmm0
	jmp near ptr 00000001806B2DBFh
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x18, rbx
	002 Move stack:0x20, rsi
	003 ShiftStack -8
	004 Move stack:0x0, rdi
	005 ShiftStack -128
	006 Compare [0x184EEB665], 0
	007 Move rbx, rdx
	008 Move rdi, rcx
	009 JumpIfNotEqual {31}
	010 LoadAddress rcx, [0x184C2AFC0]
	011 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	012 LoadAddress rcx, [0x184C75168]
	013 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	014 LoadAddress rcx, [0x184C984C0]
	015 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	016 LoadAddress rcx, [0x184C40BB0]
	017 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	018 LoadAddress rcx, [0x184C98310]
	019 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	020 LoadAddress rcx, [0x184C3A350]
	021 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	022 LoadAddress rcx, [0x184C93578]
	023 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	024 LoadAddress rcx, [0x184C3B660]
	025 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	026 LoadAddress rcx, [0x184C3C2C8]
	027 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	028 LoadAddress rcx, [0x184C95228]
	029 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	030 Move [0x184EEB665], 1
	031 Compare [0x184EEB658], 0
	032 Move [rdi+136], 26
	033 Move [rdi+160], 1500
	034 Move rsi, "anim_shooting"
	035 JumpIfNotEqual {41}
	036 LoadAddress rcx, [0x184C92A80]
	037 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	038 LoadAddress rcx, [0x184C911F8]
	039 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	040 Move [0x184EEB658], 1
	041 Move stack:0x98, rbp
	042 Move stack:0x70, xmm6
	043 Move stack:0x60, xmm7
	044 Move stack:0x50, xmm8
	045 Compare rsi, 0
	046 JumpIfEqual {439}
	047 Move r8, ""
	048 Move r9, 0
	049 Move rdx, "anim_"
	050 Move rcx, rsi
	051 Call String.Replace, rcx, rdx, r8
	052 Move rcx, [rdi+320]
	053 Move rsi, rax
	054 Compare rcx, 0
	055 JumpIfEqual {439}
	056 Move xmm8, [0x183C33DBC]
	057 Move r9, 0
	058 Move xmm1, xmm8
	059 Move r8, 0
	060 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	061 Move rcx, [rdi+320]
	062 Compare rcx, 0
	063 JumpIfEqual {439}
	064 Move xmm3, [0x183C33DB4]
	065 Move rbp, 0
	066 Move stack:0x28, rbp
	067 Move r8, 0
	068 Move rdx, rsi
	069 Move stack:0x20, 3
	070 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	071 Move r8, [rdi+16]
	072 Compare r8, 0
	073 JumpIfEqual {439}
	074 Move r8, [r8+88]
	075 Compare r8, 0
	076 JumpIfEqual {439}
	077 Move rdx, typeof(Reloaded.Services.IAudioService)
	078 Move rcx, 6
	079 Move r9, 42
	080 Call 0x180002040, rcx, rdx, r8, r9
	081 Move rdx, 0
	082 Move rcx, rdi
	083 Call Plant.GetFreeMagnetItem, rcx, rdx
	084 Move rdi, rax
	085 Compare rbx, 0
	086 JumpIfEqual {439}
	087 Compare [rbx+284], 2
	088 JumpIfEqual {385}
	089 Compare [rbx+284], 3
	090 JumpIfEqual {332}
	091 Compare [rbx+304], 1
	092 JumpIfEqual {281}
	093 Compare [rbx+304], 5
	094 JumpIfEqual {281}
	095 Compare [rbx+304], 3
	096 JumpIfEqual {243}
	097 Compare [rbx+112], 18
	098 JumpIfEqual {186}
	099 Compare [rbx+116], 15
	100 JumpIfEqual {140}
	101 Compare [rbx+112], 17
	102 JumpIfNotEqual {232}
	103 Move rdx, 0
	104 Move rcx, rbx
	105 Call Zombie.DiggerLoseAxe, rcx, rdx
	106 Move rdx, "Zombie_digger_pickaxe"
	107 Move r8, 0
	108 Move rcx, rbx
	109 Call Zombie.GetTrackPosition, rcx, rdx
	110 Move stack:0x90, rax
	111 Compare rdi, 0
	112 JumpIfEqual {439}
	113 Move xmm0, stack:0x90
	114 Move xmm1, 0
	115 Subtract xmm0, xmm0, xmm1
	116 Move [rdi+16], xmm0
	117 Move xmm0, stack:0x94
	118 Subtract xmm0, xmm0, xmm1
	119 Move [rdi+20], xmm0
	120 Move rcx, typeof(Reloaded.Gameplay.Common)
	121 Compare [rcx+228], rbp
	122 JumpIfNotEqual {124}
	123 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	124 Move xmm7, [0x183C33DAC]
	125 Move r8, 0
	126 Move xmm6, [0x183C33F38]
	127 Move xmm1, xmm7
	128 Move xmm0, xmm6
	129 Call Common.RandRangeFloat, xmm0, xmm1, r8
	130 Add xmm0, xmm0, [0x183C33E28]
	131 Move r8, 0
	132 Move xmm1, xmm7
	133 Move [rdi+24], xmm0
	134 Move xmm0, xmm6
	135 Call Common.RandRangeFloat, xmm0, xmm1, r8
	136 Add xmm0, xmm0, [0x183C33DB8]
	137 Move [rdi+32], 21
	138 Move [rdi+28], xmm0
	139 Goto {232}
	140 Move rdx, 0
	141 Move rcx, rbx
	142 Call Zombie.StopZombieSound, rcx, rdx
	143 Move rdx, 0
	144 Move rcx, rbx
	145 Call Zombie.PickRandomSpeed, rcx, rdx
	146 Move [rbx+116], rbp
	147 Move r9, 0
	148 Move rdx, "Zombie_jackbox_box"
	149 Move r8, 0xFFFFFFFF
	150 Move rcx, rbx
	151 Call Zombie.ReanimShowTrack, rcx, rdx, r8
	152 Move rdx, "Zombie_jackbox_box"
	153 Move r8, 0
	154 Move rcx, rbx
	155 Call Zombie.GetTrackPosition, rcx, rdx
	156 Move stack:0x90, rax
	157 Compare rdi, 0
	158 JumpIfEqual {439}
	159 Move xmm0, stack:0x90
	160 Move xmm1, 0
	161 Subtract xmm0, xmm0, xmm1
	162 Move [rdi+16], xmm0
	163 Move xmm0, stack:0x94
	164 Subtract xmm0, xmm0, xmm1
	165 Move [rdi+20], xmm0
	166 Move rcx, typeof(Reloaded.Gameplay.Common)
	167 Compare [rcx+228], rbp
	168 JumpIfNotEqual {170}
	169 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	170 Move xmm7, [0x183C33DAC]
	171 Move r8, 0
	172 Move xmm6, [0x183C33F38]
	173 Move xmm1, xmm7
	174 Move xmm0, xmm6
	175 Call Common.RandRangeFloat, xmm0, xmm1, r8
	176 Add xmm0, xmm0, xmm8
	177 Move r8, 0
	178 Move xmm1, xmm7
	179 Move [rdi+24], xmm0
	180 Move xmm0, xmm6
	181 Call Common.RandRangeFloat, xmm0, xmm1, r8
	182 Add xmm0, xmm0, [0x183C33DB8]
	183 Move [rdi+32], 13
	184 Move [rdi+28], xmm0
	185 Goto {232}
	186 Move r8, 0
	187 Move rdx, 16
	188 Move rcx, rbx
	189 Call Zombie.PogoBreak, rcx, rdx
	190 Move r8, 0
	191 LoadAddress rcx, stack:0x30
	192 Move rdx, rbx
	193 Call Zombie.GetDrawPos, rcx, rdx
	194 Move rdx, "Zombie_pogo_stick"
	195 Move r8, 0
	196 Move rcx, rbx
	197 Call Zombie.GetTrackPosition, rcx, rdx
	198 Move stack:0x90, rax
	199 Compare rdi, 0
	200 JumpIfEqual {439}
	201 Move xmm0, stack:0x90
	202 Move xmm1, stack:0x94
	203 Add xmm0, xmm0, [0x183C33DC4]
	204 Add xmm1, xmm1, [0x183C33FF0]
	205 Move [rdi+16], xmm0
	206 Move [rdi+20], xmm1
	207 Move rcx, typeof(Reloaded.Gameplay.Common)
	208 Compare [rcx+228], rbp
	209 JumpIfNotEqual {211}
	210 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	211 Move xmm7, [0x183C33DAC]
	212 Move r8, 0
	213 Move xmm6, [0x183C33F38]
	214 Move xmm1, xmm7
	215 Move xmm0, xmm6
	216 Call Common.RandRangeFloat, xmm0, xmm1, r8
	217 Add xmm0, xmm0, [0x183C33FD8]
	218 Move r8, 0
	219 Move xmm1, xmm7
	220 Move [rdi+24], xmm0
	221 Move xmm0, xmm6
	222 Call Common.RandRangeFloat, xmm0, xmm1, r8
	223 Add xmm0, xmm0, xmm7
	224 Move rax, 10
	225 Move rcx, 12
	226 Move [rdi+28], xmm0
	227 Compare [rbx+275], rbp
	228 JumpIfNotEqual {230}
	229 Move rax, rcx
	230 Nop 
	231 Move [rdi+32], rax
	232 Move xmm8, stack:0x50
	233 LoadAddress r11, stack:0x80
	234 Move rbx, [r11+32]
	235 Move rsi, [r11+40]
	236 Move xmm7, stack:0x60
	237 Move xmm6, stack:0x70
	238 Move rbp, stack:0x98
	239 Move rsp, r11
	240 Move rdi, stack:0x0
	241 ShiftStack 8
	242 Return 
	243 Move rdx, 0
	244 Move rcx, rbx
	245 Call Zombie.GetShieldDamageIndex, rcx, rdx
	246 Move rdx, 0
	247 Move rcx, rbx
	248 Move rsi, rax
	249 Call Zombie.DetachShield, rcx, rdx
	250 Compare rdi, 0
	251 JumpIfEqual {439}
	252 Move xmm1, [rbx+120]
	253 Move xmm0, 0
	254 Add xmm1, xmm1, [0x183C33FC0]
	255 Move [rdi+16], xmm1
	256 Subtract xmm1, xmm1, xmm0
	257 Move xmm2, [rbx+124]
	258 Add xmm2, xmm2, xmm8
	259 Move [rdi+16], xmm1
	260 Subtract xmm2, xmm2, xmm0
	261 Move [rdi+20], xmm2
	262 Move rcx, typeof(Reloaded.Gameplay.Common)
	263 Compare [rcx+228], rbp
	264 JumpIfNotEqual {266}
	265 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	266 Move xmm7, [0x183C33DAC]
	267 Move r8, 0
	268 Move xmm6, [0x183C33F38]
	269 Move xmm1, xmm7
	270 Move xmm0, xmm6
	271 Call Common.RandRangeFloat, xmm0, xmm1, r8
	272 Add xmm0, xmm0, [0x183C33C60]
	273 Move r8, 0
	274 Move xmm1, xmm7
	275 Move [rdi+24], xmm0
	276 Move xmm0, xmm6
	277 Call Common.RandRangeFloat, xmm0, xmm1, r8
	278 Move [rdi+28], xmm0
	279 LoadAddress rax, [rsi+14]
	280 Goto {231}
	281 Move rdx, 0
	282 Move rcx, rbx
	283 Call Zombie.GetShieldDamageIndex, rcx, rdx
	284 Move rdx, 0
	285 Move rcx, rbx
	286 Move rsi, rax
	287 Call Zombie.DetachShield, rcx, rdx
	288 Move [rbx+116], rbp
	289 Compare [rbx+165], rbp
	290 JumpIfNotEqual {295}
	291 Move r8, 0
	292 Move rdx, 0
	293 Move rcx, rbx
	294 Call Zombie.StartWalkAnim, rcx, rdx
	295 Move rdx, "anim_screendoor"
	296 Move r8, 0
	297 Move rcx, rbx
	298 Call Zombie.GetTrackPosition, rcx, rdx
	299 Move stack:0x90, rax
	300 Compare rdi, 0
	301 JumpIfEqual {439}
	302 Move xmm0, stack:0x90
	303 Move xmm1, 0
	304 Subtract xmm0, xmm0, xmm1
	305 Move [rdi+16], xmm0
	306 Move xmm0, stack:0x94
	307 Subtract xmm0, xmm0, xmm1
	308 Move [rdi+20], xmm0
	309 Move rcx, typeof(Reloaded.Gameplay.Common)
	310 Compare [rcx+228], rbp
	311 JumpIfNotEqual {313}
	312 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	313 Move xmm7, [0x183C33DAC]
	314 Move r8, 0
	315 Move xmm6, [0x183C33F38]
	316 Move xmm1, xmm7
	317 Move xmm0, xmm6
	318 Call Common.RandRangeFloat, xmm0, xmm1, r8
	319 Add xmm0, xmm0, [0x183C33C60]
	320 Move r8, 0
	321 Move xmm1, xmm7
	322 Move [rdi+24], xmm0
	323 Move xmm0, xmm6
	324 Call Common.RandRangeFloat, xmm0, xmm1, r8
	325 Move [rdi+28], xmm0
	326 Compare [rbx+112], 6
	327 JumpIfEqual {330}
	328 LoadAddress rax, [rsi+22]
	329 Goto {231}
	330 LoadAddress rax, [rsi+7]
	331 Goto {231}
	332 Move rdx, 0
	333 Move rcx, rbx
	334 Call Zombie.GetHelmDamageIndex, rcx, rdx
	335 Move [rbx+296], rbp
	336 Move r8, 0
	337 Move [rbx+284], rbp
	338 Move rcx, rbx
	339 Move rdx, "zombie_football_helmet"
	340 Move rsi, rax
	341 Call Zombie.GetTrackPosition, rcx, rdx
	342 Move stack:0x90, rax
	343 Compare rdi, 0
	344 JumpIfEqual {439}
	345 Move xmm0, stack:0x90
	346 Move r9, 0
	347 Move xmm1, stack:0x94
	348 Move r8, 0xFFFFFFFF
	349 Move [rdi+16], xmm0
	350 Move rcx, rbx
	351 Move [rdi+20], xmm1
	352 Move rdx, "zombie_football_helmet"
	353 Call Zombie.ReanimShowPrefix, rcx, rdx, r8
	354 Move rdx, "anim_hair"
	355 Move r9, 0
	356 Move r8, 0
	357 Move rcx, rbx
	358 Call Zombie.ReanimShowPrefix, rcx, rdx, r8
	359 Move xmm0, [rbx+120]
	360 Add xmm0, xmm0, [0x183C33FD0]
	361 Move [rdi+16], xmm0
	362 Move xmm1, [rbx+124]
	363 Subtract xmm1, xmm1, [0x183C33C68]
	364 Move [rdi+20], xmm1
	365 Move rcx, typeof(Reloaded.Gameplay.Common)
	366 Compare [rcx+228], rbp
	367 JumpIfNotEqual {369}
	368 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	369 Move xmm7, [0x183C33DAC]
	370 Move r8, 0
	371 Move xmm6, [0x183C33F38]
	372 Move xmm1, xmm7
	373 Move xmm0, xmm6
	374 Call Common.RandRangeFloat, xmm0, xmm1, r8
	375 Add xmm0, xmm0, xmm8
	376 Move r8, 0
	377 Move xmm1, xmm7
	378 Move [rdi+24], xmm0
	379 Move xmm0, xmm6
	380 Call Common.RandRangeFloat, xmm0, xmm1, r8
	381 Add xmm0, xmm0, xmm8
	382 LoadAddress rax, [rsi+4]
	383 Move [rdi+28], xmm0
	384 Goto {231}
	385 Move rdx, 0
	386 Move rcx, rbx
	387 Call Zombie.GetHelmDamageIndex, rcx, rdx
	388 Move [rbx+296], rbp
	389 Move r8, 0
	390 Move [rbx+284], rbp
	391 Move rcx, rbx
	392 Move rdx, "anim_bucket"
	393 Move rsi, rax
	394 Call Zombie.GetTrackPosition, rcx, rdx
	395 Move stack:0x90, rax
	396 Compare rdi, 0
	397 JumpIfEqual {439}
	398 Move xmm0, stack:0x90
	399 Move r9, 0
	400 Move xmm1, stack:0x94
	401 Move r8, 0xFFFFFFFF
	402 Move [rdi+16], xmm0
	403 Move rcx, rbx
	404 Move [rdi+20], xmm1
	405 Move rdx, "anim_bucket"
	406 Call Zombie.ReanimShowPrefix, rcx, rdx, r8
	407 Move rdx, "anim_hair"
	408 Move r9, 0
	409 Move r8, 0
	410 Move rcx, rbx
	411 Call Zombie.ReanimShowPrefix, rcx, rdx, r8
	412 Move xmm0, [rdi+16]
	413 Move xmm1, 0
	414 Subtract xmm0, xmm0, xmm1
	415 Move [rdi+16], xmm0
	416 Move xmm0, [rdi+20]
	417 Subtract xmm0, xmm0, xmm1
	418 Move [rdi+20], xmm0
	419 Move rcx, typeof(Reloaded.Gameplay.Common)
	420 Compare [rcx+228], rbp
	421 JumpIfNotEqual {423}
	422 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	423 Move xmm7, [0x183C33DAC]
	424 Move r8, 0
	425 Move xmm6, [0x183C33F38]
	426 Move xmm1, xmm7
	427 Move xmm0, xmm6
	428 Call Common.RandRangeFloat, xmm0, xmm1, r8
	429 Add xmm0, xmm0, [0x183C33DC0]
	430 Move r8, 0
	431 Move xmm1, xmm7
	432 Move [rdi+24], xmm0
	433 Move xmm0, xmm6
	434 Call Common.RandRangeFloat, xmm0, xmm1, r8
	435 Add xmm0, xmm0, xmm8
	436 LoadAddress rax, [rsi+1]
	437 Move [rdi+28], xmm0
	438 Goto {231}
	439 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
