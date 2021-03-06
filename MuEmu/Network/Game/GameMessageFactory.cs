﻿using MuEmu.Network.Event;
using MuEmu.Network.MuunSystem;
using MuEmu.Network.Pentagrama;
using MuEmu.Network.UBFSystem;
using System;
using System.Collections.Generic;
using System.Text;
using WebZen.Network;

namespace MuEmu.Network.Game
{
    public interface IGameMessage
    { }

    public class GameMessageFactory : MessageFactory<GameOpCode, IGameMessage>
    {
        public GameMessageFactory()
        {
            // C2S
            Register<CCheckSum>(GameOpCode.GameSecurity);
            Register<SMapMoveCheckSum>(GameOpCode.MapMoveCheckSum);
            Register<CClientMessage>(GameOpCode.ClientMessage);
            Register<CCloseWindow>(GameOpCode.CloseWindow);

            Register<CAction>(GameOpCode.Rotation);
            Register<CMove>(GameOpCode.Move);
            Register<CMoveEng>(GameOpCode.MoveEng);
            Register<CPositionSet>(GameOpCode.Position);

            #region Client ChatMessages
            Register<CChatNickname>(GameOpCode.GeneralChat0);
            Register<CChatNumber>(GameOpCode.GeneralChat1);
            Register<CChatWhisper>(GameOpCode.WhisperChat);
            #endregion

            Register<CTeleport>(GameOpCode.Teleport);
            Register<CInventory>(GameOpCode.Inventory);
            Register<CNewQuestInfo>(GameOpCode.QuestDetails);
            Register<CPointAdd>(GameOpCode.PointAdd);
            Register<CClientClose>(GameOpCode.ClientClose);
            Register<CMoveItem>(GameOpCode.MoveItem);
            Register<CUseItem>(GameOpCode.HealthUpdate); // Same OPCode
            Register<CEventEnterCount>(GameOpCode.EventEnterCount);
            Register<CTalk>(GameOpCode.Talk);
            Register<CWarehouseUseEnd>(GameOpCode.WarehouseUseEnd);
            Register<CBuy>(GameOpCode.Buy);
            Register<CSell>(GameOpCode.Sell);
            Register<CWarp>(GameOpCode.Warp);
            Register<CDataLoadOK>(GameOpCode.DataLoadOK);
            Register<CJewelMix>(GameOpCode.JewelMix);
            Register<CJewelUnMix>(GameOpCode.JewelUnMix);
            Register<CChaosBoxItemMixButtonClick>(GameOpCode.ChaosBoxItemMixButtonClick);
            Register<CChaosBoxUseEnd>(GameOpCode.ChaosBoxUseEnd);
            Register<CItemThrow>(GameOpCode.ItemThrow);
            Register<CItemGet>(GameOpCode.ItemGet);
            Register<CItemModify>(GameOpCode.ItemModify);

            #region Client PersonalShopMessages
            Register<CPShopSetItemPrice>(GameOpCode.PShopSetItemPrice);
            Register<CPShopRequestOpen>(GameOpCode.PShopRequestOpen);
            Register<CPShopRequestClose>(GameOpCode.PShopRequestClose);
            Register<CPShopRequestList>(GameOpCode.PShopRequestList);
            Register<CPShopRequestBuy>(GameOpCode.PShopRequestBuy);
            #endregion

            #region Client AttackMessages
            //Register<CAttackS5E2>(GameOpCode.Attack);
            switch(Program.Season)
            {
                case 9:// ENG
                    Register<CAttack>(GameOpCode.AttackEng);
                    Register<SMove>(GameOpCode.MoveEng);
                    Register<SAttackResultS9>(GameOpCode.AttackEng);
                    Register<CMagicAttackS9>(GameOpCode.MagicAttack);
                    break;
                default:
                    Register<CAttack>(GameOpCode.Attack);
                    Register<SMove>(GameOpCode.Move);
                    Register<SAttackResult>(GameOpCode.Attack);
                    Register<CMagicAttack>(GameOpCode.MagicAttack);
                    break;
            }
            Register<CMagicDuration>(GameOpCode.MagicDuration);
            Register<CBeattack>(GameOpCode.Beattack);
            #endregion

            #region Client PartyMessages
            Register<CPartyRequest>(GameOpCode.PartyRequest);
            Register<CPartyRequestResult>(GameOpCode.PartyResult);
            Register<CPartyList>(GameOpCode.PartyList);
            Register<CPartyDelUser>(GameOpCode.PartyDelUser);
            #endregion

            #region Client DuelMessages
            Register<CDuelRequest>(GameOpCode.DuelRequest);
            Register<CDuelAnswer>(GameOpCode.DuelAnswer);
            Register<CDuelLeave>(GameOpCode.DuelLeave);
            Register<CDuelJoinRoom>(GameOpCode.DuelRoomJoin);
            Register<CDuelLeaveRoom>(GameOpCode.DuelRoomLeave);
            #endregion

            #region Client FriendMessages
            Register<CFriendList>(GameOpCode.FriendList);
            Register<CFriendAdd>(GameOpCode.FriendAdd);
            Register<CWaitFriendAddReq>(GameOpCode.FriendAddWait);
            Register<SFriendAddReq>(GameOpCode.FriendAdd);
            Register<SFriendAddSin>(GameOpCode.FriendAddWait);
            #endregion

            #region MasterSystemMessages
            Register<CMasterSkill>(GameOpCode.MasterLevelSkill);
            #endregion

            // S2C
            Register<SInventory>(GameOpCode.Inventory);
            Register<SEquipament>(GameOpCode.Equipament);
            Register<SCheckSum>(GameOpCode.GameSecurity);
            Register<SWeather>(GameOpCode.Weather);
            Register<SSpells>(GameOpCode.Spells);
            Register<SQuestInfo>(GameOpCode.QuestInfo);
            Register<SFriends>(GameOpCode.FriendList);
            Register<SKillCount>(GameOpCode.KillCount);

            Register<SChatNickName>(GameOpCode.GeneralChat0);
            Register<SChatTarget>(GameOpCode.GeneralChat1);

            #region Server ViewPortMessages
            Register<SViewPortCreate>(GameOpCode.ViewPortCreate);
            Register<SViewPortChange>(GameOpCode.ViewPortChange);
            Register<SViewPortCreateS9>(GameOpCode.ViewPortCreate);
            Register<SViewPortChangeS9>(GameOpCode.ViewPortChange);
            Register<SViewPortMonCreate>(GameOpCode.ViewPortMCreate);
            Register<SViewPortMonCreateS9>(GameOpCode.ViewPortMCreate);
            Register<SViewPortDestroy>(GameOpCode.ViewPortDestroy);
            Register<SViewPortItemDestroy>(GameOpCode.ViewPortItemDestroy);
            #endregion

            Register<SNotice>(GameOpCode.Notice);
            Register<SEventState>(GameOpCode.EventState);
            Register<SNewQuestInfo>(GameOpCode.NewQuestInfo);
            Register<SHeatlUpdate>(GameOpCode.HealthUpdate);
            Register<SManaUpdate>(GameOpCode.ManaUpdate);
            Register<SSkillKey>(GameOpCode.SkillKey);
            Register<SAction>(GameOpCode.Rotation);
            Register<SPositionSet>(GameOpCode.Position);
            Register<SPointAdd>(GameOpCode.PointAdd);
            Register<SCharRegen>(GameOpCode.CharRegen);
            Register<SLevelUp>(GameOpCode.LevelUp);
            Register<SClinetClose>(GameOpCode.ClientClose);
            Register<SMoveItem>(GameOpCode.MoveItem);
            Register<SEventEnterCount>(GameOpCode.EventEnterCount);
            Register<SCloseMsg>(GameOpCode.ClientClose);
            Register<STalk>(GameOpCode.Talk);
            Register<SShopItemList>(GameOpCode.CloseWindow); // Same OPCode
            Register<STax>(GameOpCode.Tax);
            Register<SWarehouseMoney>(GameOpCode.WarehouseMoney);
            Register<SQuestWindow>(GameOpCode.QuestWindow);
            Register<SBuy>(GameOpCode.Buy);
            Register<SSell>(GameOpCode.Sell);
            Register<SItemGet>(GameOpCode.ItemGet);
            Register<STeleport>(GameOpCode.Teleport);
            Register<SViewSkillState>(GameOpCode.ViewSkillState);
            Register<SInventoryItemDelete>(GameOpCode.InventoryItemDelete);
            Register<SJewelMix>(GameOpCode.JewelMix);
            Register<SCommand>(GameOpCode.Command);
            Register<SSetMapAttribute>(GameOpCode.SetMapAtt);
            Register<SItemThrow>(GameOpCode.ItemThrow);
            Register<SViewPortItemCreate>(GameOpCode.ViewPortItemCreate);
            Register<SViewPortPShop>(GameOpCode.ViewPortPShop);
            Register<SInventoryItemSend>(GameOpCode.OneItemSend);
            Register<SInventoryItemDurSend>(GameOpCode.InventoryItemDurUpdate);
            Register<SChaosBoxItemMixButtonClick>(GameOpCode.ChaosBoxItemMixButtonClick);
            Register<SDamage>(GameOpCode.Damage);
            Register<SKillPlayer>(GameOpCode.KillPlayer);
            Register<SDiePlayer>(GameOpCode.DiePlayer);
            Register<SMagicAttack>(GameOpCode.MagicAttack);
            Register<SMagicDuration>(GameOpCode.MagicDuration);
            Register<SEffect>(GameOpCode.Effect);
            Register<SItemModify>(GameOpCode.ItemModify);
            Register<SItemUseSpecialTime>(GameOpCode.ItemUseSpecialTime);

            Register<SPShopSetItemPrice>(GameOpCode.PShopSetItemPrice);
            Register<SPShopRequestOpen>(GameOpCode.PShopRequestOpen);
            Register<SPShopRequestClose>(GameOpCode.PShopRequestClose);
            Register<SPShopRequestList>(GameOpCode.PShopRequestList);
            Register<SPShopRequestBuy>(GameOpCode.PShopRequestBuy);
            Register<SPShopRequestSold>(GameOpCode.PShopRequestSold);

            #region Server PartyMessages
            Register<SPartyResult>(GameOpCode.PartyResult);
            Register<SPartyList>(GameOpCode.PartyList);
            Register<SPartyDelUser>(GameOpCode.PartyDelUser);
            Register<SPartyLifeAll>(GameOpCode.PartyLifeUpdate);
            #endregion

            #region Server DuelMessages
            Register<SDuelAnsDuelInvite>(GameOpCode.DuelRequest);
            Register<SDuelAnswerReq>(GameOpCode.DuelAnswer);
            Register<SDuelAnsExit>(GameOpCode.DuelLeave);
            Register<SDuelBroadcastScore>(GameOpCode.DuelScoreBroadcast);
            Register<SDuelBroadcastHP>(GameOpCode.DuelHPBroadcast);
            Register<SDuelChannelList>(GameOpCode.DuelChannelList);
            Register<SDuelRoomJoin>(GameOpCode.DuelRoomJoin);
            Register<SDuelRoomBroadcastJoin>(GameOpCode.DuelRoomJoinBroadcast);
            Register<SDuelRoomLeave>(GameOpCode.DuelRoomLeave);
            Register<SDuelRoomBroadcastLeave>(GameOpCode.DuelRoomLeaveBroadcast);
            Register<SDuelRoomBroadcastObservers>(GameOpCode.DuelRoomObserversBroadcast);
            Register<SDuelBroadcastResult>(GameOpCode.DuelResultBroadcast);
            Register<SDuelBroadcastRound>(GameOpCode.DuelRoundBroadcast);
            #endregion

            #region Server MasterLevelMessages
            Register<SMasterInfo>(GameOpCode.MasterLevelInfo);
            Register<SMasterLevelUp>(GameOpCode.MasterLevelUp);
            Register<SMasterLevelSkill>(GameOpCode.MasterLevelSkill);
            #endregion

            Register<CTradeRequest>(GameOpCode.TradeRequest);
            Register<STradeRequest>(GameOpCode.TradeRequest);
            Register<CTradeResponce>(GameOpCode.TradeResponce);
            Register<STradeResponce>(GameOpCode.TradeResponce);
            Register<STradeOtherAdd>(GameOpCode.TradeOtherAdd);
            Register<CTradeMoney>(GameOpCode.TradeMoney);
            Register<STradeMoney>(GameOpCode.TradeMoney);
            Register<STradeOtherMoney>(GameOpCode.TradeOtherMoney);
            Register<CTradeButtonOk>(GameOpCode.TradeButtonOk);
            Register<CTradeButtonCancel>(GameOpCode.TradeButtonCancel);
            Register<STradeResult>(GameOpCode.TradeButtonCancel);

            #region MuunSystem
            Register<CMuunRideReq>(GameOpCode.MuunRideRequest);
            Register<SMuunRideVP>(GameOpCode.MuunRideViewPort);
            #endregion

            Register<SMiniMapNPC>(GameOpCode.MiniMapNPC);

            Register<SPeriodItemCount>(GameOpCode.PeriodItemCount);

            Register<SPentagramaJewelInfo>(GameOpCode.PentagramaJInfo);

            Register<SUBFInfo>(GameOpCode.UBFInfo);
            Register<CUsePopUpType>(GameOpCode.PopUpType);
            Register<SUBFPopUpType>(GameOpCode.PopUpType);

            Register<SMuunInventory>(GameOpCode.MuunInventory);

            Register<CMemberPosInfoStart>(GameOpCode.MemberPosInfoStart);
            Register<CMemberPosInfoStop>(GameOpCode.MemberPosInfoStop);

            Register<SLifeInfo>(GameOpCode.LifeInfo);
        }
    }
}
